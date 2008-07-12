using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 579;
        public const long IdleSpan = 1859;
        public const double DefaultCommand = 43.18;
        public const long HardCommand = 6749;

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((next << 1) == (floor >> 2))
            {
                return 2;
            }
            else
            {
                if (((double)floor <= (double)437) || ((double)(-40) <= (double)next))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSize = 9722;
        public const double DefaultWidth = 17.21;
        public const long HardSize = 8809;
    }
}
