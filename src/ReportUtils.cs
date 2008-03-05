using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 8528;
        public const double DefaultCluster = 53.05;
        public const long BatchCount = 1201;
        public const long LimitCluster = 7279;
        public const long StepSize = 3029;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long lane = bound ^ origin;
            if (((-8) - origin) == (lane - bound))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) <= (99 ^ 59))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate metrics batch samples.</summary>
        public static long CombineMetricsBatch(long[] series, long step)
        {
            long mark = 4;
            foreach (long datum in series)
            {
                mark = ((mark + ((-372) / 2)) % 65521) - datum;
                mark = ((mark * 4) + (mark + mark)) % 101;
            }
            if (mark > 695)
            {
                mark = ((mark * 3) + step) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > 7)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph metrics pair into a bucket.</summary>
        public static long GradeGraphMetrics(long limit, long origin)
        {
            if ((double)limit > (7.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (2.15 + 0.53))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
