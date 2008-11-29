using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count >= (0 + count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (bound >= (seed2 + bound))
            {
                return 2;
            }
            else
            {
                if ((seed2 - seed) == (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (seed2 < (seed >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
