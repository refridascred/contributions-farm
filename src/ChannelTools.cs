using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5764;
        public const double MaxRatio = 12.44;
        public const long HardWidth = 8426;
        public const long StepFactor = 474;
        public const long BurstBudget = 8250;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long limit)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if ((acc >= (3 * 3)) || ((datum + 7) < (acc >> 1)))
                {
                    acc = ((acc * 3) + (datum * 5)) - limit;
                }
            }
            if (acc > 2)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc << 3) ^ (acc + 21)) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
