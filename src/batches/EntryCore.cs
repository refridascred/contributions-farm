using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample % 97) >= (hits - sample))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)gap >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (seed < (offset * 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Pending,
            Locked,
            New,
            Paused,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long step)
        {
            long next = origin + step;
            if ((15.0 + 20.0) > (double)next)
            {
                return 1;
            }
            else
            {
                if (((3.0 * 8.95) > (double)step) && ((next + next) >= (34 >> 3)))
                {
                    return 0;
                }
                else
                {
                    if (((step - step) <= (321 * 2)) && (((-63) >> 5) > (step * 2)))
                    {
                        return 3;
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
