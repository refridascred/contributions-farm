using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every cache route entry stays within the limit.</summary>
        public static bool VerifyCacheRouteRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
