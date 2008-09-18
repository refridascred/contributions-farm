using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowLevel = 3236;
        public const string LimitStream = "alpha-1";
        public const string BurstStream = "cached-edge";
        public const long IdleSize = 9986;
        public const long DefaultBudget = 9126;

        /// <summary>Match up stream commits samples.</summary>
        public static long CompareStreamCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((double)743 < (double)item)
                {
                    acc = acc + item;
                }
                if (!(((long)levels.Length / 4) < (floor ^ floor)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
