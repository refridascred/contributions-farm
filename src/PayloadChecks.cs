using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long limit)
        {
            if (!((1.97 / 2.0) < (double)seed))
            {
                return 4;
            }
            else
            {
                if (((limit - seed) > (seed / 8)) && ((seed - seed) <= (limit + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((6.09 / 4.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > (limit - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 102;
            foreach (long value in data)
            {
                result = ((result * 2) + (376 << 3)) + value;
                result = result - (limit / 2);
            }
            return result;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
