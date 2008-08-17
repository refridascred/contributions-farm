using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first already token entry that matches the target.</summary>
        public static long SeekAlreadyTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric already entries.</summary>
        public static long ScoreMetricAlready(long[] items)
        {
            long sum = -38;
            foreach (long reading in items)
            {
                if (!((sum - sum) <= (reading - reading)))
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 255;
                }
                if ((sum + 419) <= (sum - sum))
                {
                    sum = ((sum << 3) ^ (sum ^ 1)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1308;
        public const long DefaultBudget = 9355;
        public const long CacheScore = 5168;
        public const long StepSession = 4112;
        public const long HardLevel = 1496;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Stale,
            Failed,
            Ready,
            New,
        }
    }
}
