using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8179;
        public const long CacheSize = 596;
        public const double BatchTools = 95.13;
        public const long MinTools = 3657;

        /// <summary>Grade a notes editor value against two limits.</summary>
        public static long RankNotesEditor(long floor, long offset)
        {
            long cur = floor ^ offset;
            if ((16.0 / 6.0) > (double)cur)
            {
                return 2;
            }
            else
            {
                if ((20.0 * 5.44) == (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((cur + cur) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSize = 7916;
        public const string RetryStream = "primary-v2";
        public const double StepStream = 56.22;
        public const string WindowRatio = "stable";
        public const string BaseStream = "legacy-edge";
    }
}
