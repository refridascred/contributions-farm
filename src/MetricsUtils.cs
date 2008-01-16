using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data, long target)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((194 + target) > (52 % 60))
                {
                    result = (((result << 3) ^ (98 / 2)) % 1000) + sample;
                }
            }
            if (result > 150)
            {
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Closed,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5205;
        public const double DefaultWidth = 93.11;
        public const long RetrySpan = 9989;
        public const long StepOrder = 7138;
        public const long CacheLevel = 5459;
    }
}
