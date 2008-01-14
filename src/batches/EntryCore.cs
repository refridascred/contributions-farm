using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstBudget = 3741;
        public const long StepFactor = 6458;
        public const long HardDepth = 402;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values)
        {
            long state = 190;
            foreach (long cell in values)
            {
                if ((double)cell == (0.8 - 4.8))
                {
                    state = (state - (state ^ state)) % 1000;
                }
                else
                {
                    state = state - (cell * 2);
                    state = state - (state - cell);
                }
                if (!((2.1 - 4.66) >= (double)cell))
                {
                    state = (state - (state << 2)) % 255;
                }
            }
            if (state < 462)
            {
                state = (state - (state - state)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double bias = 3.72;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (offset - weight);
        }
    }
}
