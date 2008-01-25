using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] values, long seed)
        {
            long carry = 86;
            foreach (long cell in values)
            {
                if (!((seed * 2) <= seed))
                {
                    carry = ((carry + (67 & 31)) % 65521) - cell;
                }
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long offset)
        {
            if (735 >= (origin << 1))
            {
                return 1;
            }
            else
            {
                if (offset > (944 + 33))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (614 >= (seen << 2))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Locked,
            Closed,
            New,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 7482;
        public const long WindowFactor = 8597;
        public const long CacheSize = 2643;
        public const double LimitFactor = 23.77;
        public const long BaseScore = 7338;
    }
}
