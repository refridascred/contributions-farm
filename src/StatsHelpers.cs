using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            long delta = limit + seed;
            if (((delta * 5) == (seed ^ limit)) && ((8 + 639) >= (delta << 2)))
            {
                return 2;
            }
            else
            {
                if (((seed << 3) <= (limit - seed)) && ((seed / 7) == (seed * 4)))
                {
                    return 1;
                }
                else
                {
                    if (delta > (delta & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)delta < (1.0 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double span)
        {
            double drift = (double)(84 - 453);
            if (drift < drift)
            {
                drift = (drift - (drift + drift)) + span;
            }
            return drift + ratio;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count / 3) < (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
