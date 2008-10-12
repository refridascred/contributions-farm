using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((40 + 6) >= (tally + floor))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "standard-edge";
        public const long RetryLevel = 9473;
        public const double WindowBatch = 52.8;
        public const long CacheInterval = 2158;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long target)
        {
            long delta = offset ^ target;
            if (!((36 * 4) != (target / 8)))
            {
                return 8;
            }
            else
            {
                if ((delta + offset) > (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if (delta > (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(delta > (delta ^ target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
