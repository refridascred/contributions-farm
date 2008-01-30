using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)36 != (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowFactor = "standard-edge";
        public const string BurstBudget = "standard";
        public const long SoftLevel = 898;
        public const string MaxCluster = "latest-edge";
        public const string MinLevel = "latest-edge";

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
