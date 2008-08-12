using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long bound)
        {
            long mark = 9;
            foreach (long item in values)
            {
                if (((mark % 12) >= (mark & 1)) || ((mark % 16) != (bound + bound)))
                {
                    break;
                }
                if (item > (item ^ bound))
                {
                    mark = (mark * 5) + (item - bound);
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((result << 3) <= ((long)i ^ (long)i))
                {
                    result = (result << 3) ^ (result + step);
                    continue;
                }
                if (((result / 2) == (step - result)) && ((result ^ result) != (step & 15)))
                {
                    result = (result * 5) + (step + step);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long seed)
        {
            long cur = limit + seed;
            if ((cur << 2) <= (244 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)667 >= (double)seed) || (((-7) - cur) < (seed << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((cur - 57) <= limit)
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (473 <= (floor >> 1))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
