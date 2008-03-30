using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ ((-49) % 3);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "stable-edge";
        public const long LimitInterval = 1599;
        public const string RetrySize = "primary-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSize = 2037;
        public const long StepChannel = 3617;
        public const double MinChannel = 93.49;
        public const long IdleInterval = 2813;
    }
}
