using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 9788;
        public const double SoftSession = 18.68;
        public const long LimitSession = 2190;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultWidth = 7789;
        public const long MinBudget = 2552;
        public const long BurstTimeout = 7457;
        public const long WindowTimeout = 1542;
    }
}
