using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long limit)
        {
            long prev = target + limit;
            if ((2.4 <= (double)limit) || ((55 % 16) >= target))
            {
                return 3;
            }
            else
            {
                if ((limit & 7) <= (775 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((double)588 < (double)prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 3) > (prev >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long floor)
        {
            if (floor > bound)
            {
                return 5;
            }
            else
            {
                if (((bound * 3) > bound) || ((5.4 - 19.0) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (((floor + bound) < (36 / 5)) || ((bound - 155) == (floor & 31)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((256 % 64) != (item % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
