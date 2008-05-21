using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                sum = sum ^ entry;
                if ((entry + entry) != (entry + sum))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum ^ (65 / 8);
            }
            return sum % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseBudget = 93.79;
        public const long StepFactor = 2924;
        public const long SoftSpan = 6112;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels)
        {
            long total = 75;
            foreach (long entry in levels)
            {
                total = (total + 567) % 255;
                if (((entry + total) < (total ^ total)) && (total > 2))
                {
                    total = (total ^ (total + (-8))) % 1000;
                }
                total = (total * 4) + (entry ^ (-527));
            }
            return total % 1000;
        }
    }
}
