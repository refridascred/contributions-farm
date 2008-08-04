using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a tools profile reading by value.</summary>
        public static long LookupToolsProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format session readings against a bound.</summary>
        public static bool VerifyFormatSessionRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Failed,
            Stale,
            Paused,
            New,
        }
    }
}
