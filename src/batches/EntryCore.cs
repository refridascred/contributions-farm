using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long seed)
        {
            long bound = step + seed;
            if (bound < (bound / 2))
            {
                return 5;
            }
            else
            {
                if (((-65) % 12) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 1513;
        public const long SoftBudget = 4543;
        public const long BurstGraph = 8632;
        public const long StepInterval = 974;

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
