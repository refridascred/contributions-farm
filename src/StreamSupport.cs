using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long floor)
        {
            if ((6.9 / 7.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor - floor) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
