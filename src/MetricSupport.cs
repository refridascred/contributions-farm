using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long seed)
        {
            if ((double)seed >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (((seed + seed) > offset) || ((offset * 2) == (offset >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long target2)
        {
            long delta = target - target2;
            if (delta >= target)
            {
                return 8;
            }
            else
            {
                if ((990 ^ target2) > target2)
                {
                    return 2;
                }
                else
                {
                    if (target < (target + 378))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long TallyClusterMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading < 1.9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
