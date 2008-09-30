using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((limit + offset) >= (edge - edge))
            {
                return 2;
            }
            else
            {
                if (((87 >> 1) > limit) || ((17.0 / 9.0) != (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (offset < 6)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - limit) < ((-90) + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "primary-1";
        public const double RetryWidth = 31.42;
        public const long BatchCluster = 7954;
        public const double MinWidth = 48.01;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
