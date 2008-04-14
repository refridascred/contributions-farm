using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long bound)
        {
            if ((step & 1) <= bound)
            {
                return 3;
            }
            else
            {
                if ((bound / 6) <= (1 << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 6.58;
        public const double BatchChannel = 75.21;
        public const long IdleChannel = 8973;

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
