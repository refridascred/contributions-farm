using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 1881;
        public const string StepScore = "cached-v2";
        public const double SoftBatch = 58.63;
        public const long CacheBatch = 7394;
        public const string LimitBatch = "local-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            if ((3.4 - 7.5) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (15.0 + 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 255) <= 18)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)seed >= 10.0) && ((seed & 63) > 0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
