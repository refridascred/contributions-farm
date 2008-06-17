using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long target)
        {
            long span = offset ^ target;
            if ((target - span) > (target - target))
            {
                return 7;
            }
            else
            {
                if ((double)span != (double)519)
                {
                    return 3;
                }
                else
                {
                    if (((span ^ offset) == (target >> 1)) || ((span ^ 986) != (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long offset)
        {
            if (12.0 >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset << 3) > (origin - origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token metrics readings against a rule.</summary>
        public static long AuditTokenMetricsGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches != (double)origin)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Locked,
            Ready,
            Closed,
            Stale,
        }
    }
}
