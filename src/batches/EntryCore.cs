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

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double weight = span;
            return (weight + (span * 12.0)) + gain;
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
