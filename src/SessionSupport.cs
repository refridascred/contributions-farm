using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long floor2)
        {
            if ((floor2 < (floor2 << 2)) && ((floor2 * 2) <= (floor ^ floor)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (20.0 - 6.0))
                {
                    return 5;
                }
                else
                {
                    if (!((floor << 2) < (floor2 + floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(10.0 >= (double)floor))
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
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
