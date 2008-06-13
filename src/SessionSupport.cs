using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long anchor = 11;
            foreach (long value in readings)
            {
                anchor = (anchor << 3) ^ (value * 3);
                if (!((value ^ anchor) != (value >> 2)))
                {
                    anchor = (anchor * 2) + (value * 4);
                }
                else
                {
                    anchor = (anchor ^ (value - value)) % 1000;
                }
                if (anchor <= (value * 2))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            if (anchor < (-42))
            {
                anchor = (anchor - (6 * 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally >> 5) == (tally * 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
