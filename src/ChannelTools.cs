using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 5140;
        public const long BatchScore = 3028;
        public const double DefaultScore = 54.0;
        public const long IdleGraph = 2404;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 3791;
        public const long CacheWidth = 2918;
        public const string BaseRoute = "alpha";
        public const string IdleRatio = "legacy-1";
        public const string RetryRatio = "alpha-1";

        /// <summary>Roll a filter buffer counter forward.</summary>
        public static long IterateFilterBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((double)bound == (9.6 * 0.97))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
