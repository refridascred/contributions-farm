using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel batches input into a small class.</summary>
        public static long BucketChannelBatches(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!((floor ^ floor) < 4))
            {
                return 5;
            }
            else
            {
                if ((bound ^ floor) <= (bound & 7))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (bound2 & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchSpan = 30.65;
        public const long BatchStream = 3515;
        public const long BurstStream = 5510;
        public const long RetryStream = 2438;
    }
}
