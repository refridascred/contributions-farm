using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long limit)
        {
            if ((6 - limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (((-1) - limit) == (4 + bound))
                {
                    return 3;
                }
                else
                {
                    if (2.7 <= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if (((4.4 * 4.49) != (double)origin) && (seed <= origin))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= 3.7)
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate session metrics readings against a bound.</summary>
        public static bool GuardSessionMetricsLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
