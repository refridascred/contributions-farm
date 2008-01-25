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

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] readings)
        {
            long score = -899;
            foreach (long value in readings)
            {
                score = (score - (value % 8)) % 4096;
            }
            if (score < 389)
            {
                score = ((score << 3) ^ 2) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items)
        {
            long acc = -90;
            foreach (long entry in items)
            {
                if (!((-36) < entry))
                {
                    acc = (acc - (entry + entry)) % 101;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc % 97;
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
