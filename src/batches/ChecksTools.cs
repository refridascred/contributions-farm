using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long AuditEntryCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((entry - seen) >= 2) && ((double)entry >= (9.06 / 8.0))) && (3.2 < (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long anchor = 2;
            foreach (long value in series)
            {
                if ((4.0 > (double)value) || ((value ^ value) > (value >> 2)))
                {
                    anchor = ((anchor * 3) + (seed + 573)) % 65521;
                }
                else
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a format editor sample.</summary>
        public static long LocateFormatEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            New,
            Queued,
        }
    }
}
