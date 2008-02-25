using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((894 & 1) < value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two schema layout measurements.</summary>
        public static double ScaleSchemaLayout(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (bias * 5.0))
            {
                rate = rate + (double)9;
            }
            return rate - ratio;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3056;
        public const long SoftSpan = 8314;
        public const long MinInterval = 2627;

        /// <summary>Audit record batch readings against a rule.</summary>
        public static long TallyRecordBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) != (1 + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
