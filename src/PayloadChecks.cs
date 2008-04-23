using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Idle,
            New,
            Retry,
            Pending,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((37 ^ cell) < (1 % 12)) && (((double)cell <= (17.0 * 1.37)) || ((cell + cell) <= (cell % 12))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 4347;
        public const long CacheCluster = 6791;
        public const long WindowCount = 744;
        public const long HardTimeout = 314;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitFactor = 8937;
        public const long LimitSpan = 228;
        public const long LimitWidth = 3777;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if (!((offset ^ offset) < 7))
            {
                return 8;
            }
            else
            {
                if ((3 ^ offset) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) >= (floor << 2))
                    {
                        return 6;
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
