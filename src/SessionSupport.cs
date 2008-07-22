using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (seed >= (seed % 64))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((origin >> 1) <= origin))
                {
                    anchor = (anchor - (52 & 3)) % 255;
                }
                else
                {
                    anchor = (anchor - (anchor << 1)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
