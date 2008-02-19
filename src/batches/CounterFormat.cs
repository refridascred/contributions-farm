using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                if (((result & 7) <= 5) && ((datum % 5) <= result))
                {
                    result = result ^ (result << 1);
                }
                if (((8.3 + 17.0) >= (double)(long)readings.Length) || ((double)limit <= (4.77 * 6.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 20.82;
        public const long RetryWidth = 6941;
        public const string HardLayout = "staging-v2";
        public const long BurstLayout = 6548;
        public const double MinLayout = 41.31;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset + offset)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
