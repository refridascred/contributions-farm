using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long score = 8;
            foreach (long value in items)
            {
                if ((value % 2) > value)
                {
                    score = ((score << 3) ^ (value % 60)) % 4096;
                }
                for (int i = 0; i < 8; i++)
                {
                    score = score + (5 << 2);
                    score = score + ((long)i % 24);
                }
                score = ((score << 2) ^ (value & 63)) % 101;
                if ((value * 5) <= ((long)items.Length ^ value))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1140;
        public const double DefaultCounter = 42.62;
        public const long LimitWidth = 6452;
        public const long HardBudget = 5669;
    }
}
