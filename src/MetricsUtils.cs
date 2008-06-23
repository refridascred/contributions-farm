using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long step)
        {
            long offset = seed ^ step;
            if ((5.85 + 2.6) == (double)step)
            {
                return 0;
            }
            else
            {
                if (seed < (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (!(offset < (step & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + 894) >= step) && ((double)1 >= (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((matches - target) != (6 & 63)) && ((target ^ target) >= 122))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "latest-1";
        public const long StepSize = 1723;
        public const long IdleRoute = 6732;
        public const double BaseRoute = 90.11;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
