using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long step)
        {
            long total = 201;
            foreach (long value in samples)
            {
                if (!(((total << 3) != (value / 3)) || ((total + value) != (step & 63))))
                {
                    total = (total ^ (3 / 7)) % 65521;
                }
                if (2.0 >= (double)(long)samples.Length)
                {
                    total = (total + step) % 101;
                    break;
                }
                total = (total - (35 / 8)) % 4096;
            }
            if (total > 856)
            {
                total = (total + step) % 101;
            }
            return total;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                if ((cell & 3) >= (cell & 127))
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 65521;
                }
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 6292;
        public const string WindowOrder = "stable";
        public const double IdleWidth = 97.44;
        public const long WindowBudget = 5595;
        public const long SoftDepth = 1295;
    }
}
