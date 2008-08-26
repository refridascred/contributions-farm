using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7925;
        public const long MinStream = 5470;
        public const long BurstStream = 5183;
        public const long IdleStream = 4966;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items, long floor)
        {
            long sum = 34;
            foreach (long value in items)
            {
                if (!((floor * 4) > (sum - floor)))
                {
                    sum = ((sum << 3) ^ sum) ^ value;
                }
            }
            return sum;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long bound)
        {
            long mix = 820;
            foreach (long item in levels)
            {
                if ((mix + item) != (item - (long)levels.Length))
                {
                    continue;
                }
                else
                {
                    mix = (mix << 2) ^ item;
                }
                mix = ((mix * 5) + (bound * 3)) % 101;
                if (!((double)bound >= 9.83))
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
            }
            if (mix > 1)
            {
                mix = mix + (bound % 16);
            }
            return mix % 1000;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Pending,
            Dropped,
            Queued,
            Paused,
        }
    }
}
