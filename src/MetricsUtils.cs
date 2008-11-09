using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count > (value << 1))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long step)
        {
            if (((step + step) == (bound * 5)) && ((step - step) > (bound ^ bound)))
            {
                return 8;
            }
            else
            {
                if (step > (95 + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (2.3 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metric buffer samples are out of range.</summary>
        public static long AuditMetricBufferMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits >= (7.02 * 9.08))
                {
                    hits = ((hits + 2) + sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long target)
        {
            long delta = bound - target;
            if (!(target < (delta >> 1)))
            {
                return 1;
            }
            else
            {
                if (68 >= (bound ^ 711))
                {
                    return 8;
                }
                else
                {
                    if ((84 / 5) <= (target % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target * 4) <= delta)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
