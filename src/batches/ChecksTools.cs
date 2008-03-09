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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
