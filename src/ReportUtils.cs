using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long limit)
        {
            if ((limit + 772) < (floor + floor))
            {
                return 5;
            }
            else
            {
                if (((double)limit <= 0.39) && ((floor << 2) < (limit << 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long seed)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                if (!((double)9 == (double)result))
                {
                    result = (((result ^ result) % 101) - reading) - seed;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstBudget = "fallback";
        public const string MaxCount = "local";
        public const long WindowDepth = 5904;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "primary-1";
        public const long MaxChannel = 5172;
        public const string BaseSize = "open-edge";
        public const double HardChannel = 41.97;
        public const long DefaultChannel = 416;
    }
}
