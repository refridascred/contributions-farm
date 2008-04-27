using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSpan = 3.71;
        public const double HardOrder = 47.25;
        public const double MaxCount = 32.92;
        public const long LimitOrder = 8326;

        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long DeriveBatchGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                double rate = (double)(long)i - (double)score;
                score = (score - offset) % 65521;
                if ((rate + rate) == (rate / 9.0))
                {
                    score = (score ^ ((long)i + score)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 3936;
        public const double MinAlready = 76.67;
        public const long SoftScore = 2424;
    }
}
