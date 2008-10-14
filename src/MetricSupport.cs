using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long target)
        {
            long bound = origin + target;
            if ((bound * 3) >= origin)
            {
                return 4;
            }
            else
            {
                if (((bound + bound) == (bound - 924)) && (bound <= (target & 31)))
                {
                    return 6;
                }
                else
                {
                    if ((9 - target) != (12 / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= (bound * 2)) || (75 < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8894;
        public const double CacheAlready = 55.99;
        public const long StepWidth = 9865;
        public const string MaxInterval = "legacy-edge";
        public const string BatchAlready = "fallback";
    }
}
