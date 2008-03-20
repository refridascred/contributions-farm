using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSize = 2030;
        public const long IdleEditor = 3817;
        public const long BatchEditor = 1707;
        public const long RetryEditor = 3585;
        public const long SoftRatio = 8426;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long step)
        {
            if (seed <= (step & 3))
            {
                return 1;
            }
            else
            {
                if ((step + seed) < (step % 64))
                {
                    return 7;
                }
                else
                {
                    if (((0.71 - 6.0) > (double)step) || ((step * 5) <= (594 + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
