using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound > ((-28) >> 3)) && ((7.2 * 20.0) < (6.0 / 9.0)))
            {
                return 3;
            }
            else
            {
                if (seed <= (origin + bound))
                {
                    return 8;
                }
                else
                {
                    if (seed >= (origin * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.6 / 4.0) != (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item - item) < (item >> 1)) || (tally < (item << 2)))
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
    }
}
