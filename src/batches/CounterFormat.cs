using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine context checks values into a single score.</summary>
        public static long TotalContextChecks(long[] levels, long offset)
        {
            long total = 17;
            foreach (long sample in levels)
            {
                if (!((double)sample == (3.6 / 2.0)))
                {
                    total = (total - sample) % 65521;
                }
                else
                {
                    total = (total ^ (sample + (-324))) % 1000;
                }
            }
            if (total > 230)
            {
                total = (total * 5) + (offset >> 5);
            }
            return total % 97;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((-188) + step) < (step + step))
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
