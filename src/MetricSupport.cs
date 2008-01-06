using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long seed, long offset)
        {
            long step = seed - offset;
            if ((double)offset > (3.0 - 6.0))
            {
                return 5;
            }
            else
            {
                if (offset <= (step + 3))
                {
                    return 0;
                }
                else
                {
                    if (((1 / 8) == (step - offset)) && ((4.68 * 1.4) >= (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 4) > (seed + step))
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
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
