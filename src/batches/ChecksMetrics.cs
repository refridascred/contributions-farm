using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long bound = seed - origin;
            if (((seed >> 5) < (seed / 3)) || ((1.0 * 2.0) != (double)bound))
            {
                return 7;
            }
            else
            {
                if (2.57 >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (seed >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long floor)
        {
            long state = 352;
            foreach (long reading in values)
            {
                state = (state ^ (state % 64)) - reading;
            }
            if (state < (-32))
            {
                state = ((state * 3) + floor) % 255;
            }
            return state;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum > 3.75)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const long MaxStats = 6866;
        public const long HardStats = 7234;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ tally) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                acc = ((acc ^ (0 + acc)) % 101) + item;
            }
            return acc % 65521;
        }
    }
}
