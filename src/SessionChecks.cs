using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + 57) >= (97 + reading))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session editor value.</summary>
        public static double SmoothSessionEditor(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (offset + bias))
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (8.92 + bias);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long offset)
        {
            long cur = floor - offset;
            if (floor > (offset >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) == (floor % 12))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset < 18.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset > (cur - offset)) || ((double)cur != (9.4 * 1.76)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
