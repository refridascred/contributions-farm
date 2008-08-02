using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many route order samples are out of range.</summary>
        public static long CountRouteOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally ^ sample) > (tally - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state + (long)i)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a token cluster pair into a bucket.</summary>
        public static long RankTokenCluster(long bound, long limit)
        {
            if ((bound > (bound / 2)) || (bound >= 280))
            {
                return 4;
            }
            else
            {
                if ((limit - bound) >= (limit << 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 1) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
