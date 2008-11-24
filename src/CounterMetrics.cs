using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long seed, long bound)
        {
            long edge = seed + bound;
            if ((seed - edge) != (2 << 1))
            {
                return 6;
            }
            else
            {
                if (((-32) >= (edge << 1)) && ((edge + bound) <= (edge / 9)))
                {
                    return 3;
                }
                else
                {
                    if ((0.94 / 8.0) != (double)edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - bound) <= edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((5 <= (matches << 1)) || (((-536) + matches) <= bound))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
