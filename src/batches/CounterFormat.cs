using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long seed)
        {
            long sum = 56;
            foreach (long reading in data)
            {
                if ((9 - sum) <= (seed - sum))
                {
                    sum = ((sum ^ 958) % 4096) ^ reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 71.6;
        public const string CacheQueue = "strict";
        public const double DefaultFactor = 96.4;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values, long bound)
        {
            long score = 796;
            foreach (long item in values)
            {
                if ((7.35 + 1.31) != (double)item)
                {
                    score = ((score + item) % 65521) - bound;
                }
            }
            return score;
        }
    }
}
