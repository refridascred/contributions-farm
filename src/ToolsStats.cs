using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long MeasureCacheWindowGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((30 % 2) <= (seen + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up token metrics samples.</summary>
        public static long OverlapTokenMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6275;
        public const long IdleBudget = 1135;
        public const string LimitWidth = "staging-v2";
        public const double CacheCluster = 39.58;
        public const string IdleCluster = "legacy-1";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value < (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
