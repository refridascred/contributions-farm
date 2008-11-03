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

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            if ((50 - 35) == (origin << 1))
            {
                return 7;
            }
            else
            {
                if (!((origin + target) < (origin / 8)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long AuditContributiBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (1 << 3))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
