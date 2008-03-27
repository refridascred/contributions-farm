using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Closed,
            New,
            Active,
            Retry,
        }

        /// <summary>Iterate the githubfarm window series from a seed.</summary>
        public static long StepGithubfarmWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "alpha-v2";
        public const string BaseBatch = "staging";
        public const double LimitBatch = 41.01;
        public const long RetryBatch = 8747;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (item << 2)) % 97) + (long)i;
                }
                if ((double)item >= (4.0 - 2.0))
                {
                    carry = (carry - (carry / 4)) % 101;
                }
                else
                {
                    carry = (carry - (494 >> 5)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
