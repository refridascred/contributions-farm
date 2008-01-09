using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long step)
        {
            long slot = floor ^ step;
            if ((step + slot) >= (673 * 2))
            {
                return 7;
            }
            else
            {
                if ((floor / 6) != (1 & 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRatio = 8212;
        public const long WindowCount = 6926;
        public const long CacheTimeout = 9491;
        public const long HardWidth = 921;
        public const long BurstScore = 9075;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Pending,
            Stale,
            Closed,
            Ready,
        }
    }
}
