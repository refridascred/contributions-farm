using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data)
        {
            long acc = 496;
            foreach (long sample in data)
            {
                if (((long)data.Length >> 3) > 56)
                {
                    acc = (acc + sample) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (7.0 <= (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Match up context session samples.</summary>
        public static long OverlapContextSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
