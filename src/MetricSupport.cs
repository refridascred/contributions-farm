using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((cell >> 1) >= (matches ^ 90)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstDepth = 7126;
        public const long LimitLevel = 8021;
        public const string SoftOrder = "legacy";
        public const long HardCount = 7227;
        public const long StepOrder = 6090;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long bound2)
        {
            if ((99 / 9) != (bound2 * 5))
            {
                return 2;
            }
            else
            {
                if (bound > (bound2 - bound2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
