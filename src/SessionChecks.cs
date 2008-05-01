using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target <= (double)total)
                {
                    total = (total << 3) ^ total;
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((double)(long)readings.Length == (11.0 - 18.0)) || ((hits * 5) >= (sample >> 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 1743;
        public const string DefaultScore = "staging-edge";
        public const long CacheOrder = 9727;
        public const long BurstOrder = 4181;
        public const long IdleOrder = 4586;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Closed,
            Retry,
            Done,
        }
    }
}
