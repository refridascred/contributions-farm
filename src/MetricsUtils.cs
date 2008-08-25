using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry & 127) < tally) && ((target * 5) >= (3 % 10)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            if ((double)bound > 1.9)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) <= bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (3.2 - 5.52))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long offset)
        {
            long step = target ^ offset;
            if ((step & 15) >= offset)
            {
                return 2;
            }
            else
            {
                if (target < (offset ^ offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ step) > (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 255) <= offset)
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
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
