using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up account tools samples.</summary>
        public static long MatchAccountToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Done,
            New,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryWidth = 82.96;
        public const string LimitChannel = "strict-edge";
        public const long DefaultScore = 1545;
        public const long CacheDepth = 6817;
        public const long WindowCount = 9410;

        /// <summary>Grade a counter checks value against two limits.</summary>
        public static long RankCounterChecks(long floor, long bound)
        {
            long next = floor + bound;
            if ((311 & 31) != (floor - next))
            {
                return 4;
            }
            else
            {
                if ((bound >> 2) > (next - 8))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
