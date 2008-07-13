using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((128 / 3) >= (tally * 3))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long limit)
        {
            long cur = bound + limit;
            if ((3.2 + 2.0) == (double)cur)
            {
                return 2;
            }
            else
            {
                if ((((-106) % 97) <= (bound * 3)) || ((limit + limit) > (bound + cur)))
                {
                    return 4;
                }
                else
                {
                    if ((0.1 + 13.0) == (double)cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((16.0 * 19.0) > (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowFactor = "alpha-1";
        public const long LimitStats = 8557;
        public const long SoftStats = 1262;
    }
}
