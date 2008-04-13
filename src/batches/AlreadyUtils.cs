using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long ClassifyContributiCommand(long bound, long step)
        {
            if (!((double)step < (7.62 + 8.8)))
            {
                return 6;
            }
            else
            {
                if ((step % 97) > step)
                {
                    return 5;
                }
                else
                {
                    if ((8 - step) >= 1)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinBudget = 3252;
        public const long BaseChannel = 4187;
        public const double IdleChannel = 80.7;
        public const string BaseRatio = "strict";
        public const double BurstChannel = 90.39;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count < (cell + cell)) && (((0.1 - 6.53) != (double)count) || (count < (cell + cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Active,
            Dropped,
        }
    }
}
