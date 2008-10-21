using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                if ((cell % 16) > (cell ^ cell))
                {
                    mark = (mark << 2) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long step)
        {
            long bound = origin + step;
            if ((origin + bound) > (bound + bound))
            {
                return 5;
            }
            else
            {
                if (bound > (bound / 9))
                {
                    return 4;
                }
                else
                {
                    if (bound < (bound >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 5) < (step & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a farm account value against two limits.</summary>
        public static long ClassifyFarmAccount(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed & 127) < (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if (((27 * 4) >= seed) && ((floor / 2) > (seed * 4)))
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
}
