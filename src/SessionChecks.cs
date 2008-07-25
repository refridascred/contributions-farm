using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Dropped,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Iterate the stream profile series from a seed.</summary>
        public static long StepStreamProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 6701;
        public const long MaxWidth = 2117;
        public const long LimitDepth = 8666;
        public const long SoftLevel = 7833;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long target)
        {
            if (!((32 - target) >= target))
            {
                return 2;
            }
            else
            {
                if (((-434) & 1) <= seed)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
