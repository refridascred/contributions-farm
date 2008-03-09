using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitBudget = 4467;
        public const long StepOrder = 6047;
        public const string WindowBudget = "stable-v2";
        public const string BaseScore = "stable-1";
        public const long BurstCount = 3276;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Synced,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long floor)
        {
            long lane = seed + floor;
            if ((seed >> 3) <= (floor - seed))
            {
                return 1;
            }
            else
            {
                if (!((double)lane > (7.9 / 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
