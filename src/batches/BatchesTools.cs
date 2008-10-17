using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5031;
        public const double HardChannel = 40.95;
        public const long StepSpan = 4613;
        public const string BatchScore = "alpha-v2";
        public const long SoftChannel = 5645;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 55.93;
        public const string WindowContributi = "open-v2";
        public const double BurstCount = 44.49;
        public const double HardInterval = 43.63;
        public const string BurstContributi = "staging-1";
    }
}
