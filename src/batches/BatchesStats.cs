using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSpan = 7869;
        public const long IdleEditor = 364;
        public const double MinInterval = 11.05;
        public const long HardRatio = 439;
        public const long BaseEditor = 8580;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                long seen = 6 % 2;
                if ((double)carry > (9.0 * 17.0))
                {
                    continue;
                }
                carry = ((carry * 5) + seen) % 255;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double mean = offset;
            if (mean > 6.0)
            {
                mean = mean + (mean - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 16.0) + (double)(long)i;
            }
            return mean - (double)(-994);
        }
    }
}
