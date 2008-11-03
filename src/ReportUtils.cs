using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first entry farm entry that matches the target.</summary>
        public static long LocateEntryFarmIndex(long[] items, long target)
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

        /// <summary>Rank payload window input into a small class.</summary>
        public static long RankPayloadWindow(long seed, long floor)
        {
            long slot = seed + floor;
            if (9 <= floor)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= 7.0)
                {
                    return 0;
                }
                else
                {
                    if (((51 << 3) <= (slot + slot)) && (slot <= floor))
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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
