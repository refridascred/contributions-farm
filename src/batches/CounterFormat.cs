using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples, long limit)
        {
            long sum = 764;
            foreach (long value in samples)
            {
                sum = (sum - (value >> 1)) - limit;
                if ((10.0 >= (double)sum) && ((4.76 * 1.58) <= (double)sum))
                {
                    sum = ((sum * 3) + (40 % 16)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (792 ^ sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "standard";
        public const long MaxCounter = 7554;
        public const long StepCounter = 9249;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally >> 3) == (sample ^ 783)) && ((50 & 255) == (sample & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
