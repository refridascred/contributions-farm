using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 5489;
        public const string BaseLayout = "standard-1";
        public const double BaseScore = 6.54;
        public const long DefaultInterval = 8590;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Validate support entry readings against a bound.</summary>
        public static bool VerifySupportEntryBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
