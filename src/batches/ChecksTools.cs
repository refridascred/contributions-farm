using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseRatio = 36.89;
        public const double BatchFactor = 84.87;
        public const long LimitBudget = 1494;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long bound)
        {
            long slot = floor - bound;
            if (!((floor & 1) < (bound ^ bound)))
            {
                return 1;
            }
            else
            {
                if ((95 + bound) > slot)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
