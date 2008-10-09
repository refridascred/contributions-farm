using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleFactor = "alpha-1";
        public const string MaxWidth = "strict";
        public const long CacheEditor = 5211;
        public const long BurstEditor = 4031;
        public const long IdleEditor = 9208;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 3908;
        public const long MaxBudget = 9163;
        public const long SoftTimeout = 4340;
        public const long MaxEntry = 3587;
        public const long CacheEntry = 101;

        /// <summary>Match up stats format samples.</summary>
        public static long MatchStatsFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            if (step >= (step * 2))
            {
                return 0;
            }
            else
            {
                if ((step + step) < (limit & 15))
                {
                    return 2;
                }
                else
                {
                    if ((step + limit) == (limit / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3 >> 3) <= (limit + 0)) && (limit <= (limit + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
