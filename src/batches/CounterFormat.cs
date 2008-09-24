using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels, long limit)
        {
            long state = 56;
            foreach (long reading in levels)
            {
                if ((reading + 3) != (649 / 4))
                {
                    state = (((state << 2) ^ (long)levels.Length) % 101) + limit;
                }
            }
            if (state < 31)
            {
                state = (state ^ ((-591) & 31)) % 101;
            }
            return state;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double rate = 9.79 + weight;
            if (rate > 9.09)
            {
                rate = rate - (weight - 4.13);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 7.03) + (double)(long)i;
            }
            return rate + (bias / 8.0);
        }
    }
}
