using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            if ((offset * 3) == (offset2 - offset2))
            {
                return 5;
            }
            else
            {
                if ((offset & 31) < offset)
                {
                    return 3;
                }
                else
                {
                    if (offset2 < (51 ^ offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the token layout entries that pass the check.</summary>
        public static long TallyTokenLayoutOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (floor < (matches % 60))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
