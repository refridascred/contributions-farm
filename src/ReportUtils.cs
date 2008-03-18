using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (span + drift)) + (double)(long)i) + ratio;
            }
            return drift + (span + 5.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 2603;
        public const long StepChecks = 6596;
        public const string BatchChecks = "stable-edge";
        public const long CacheChecks = 3413;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mark = 64;
            foreach (long sample in values)
            {
                if ((double)mark != (1.02 - 19.0))
                {
                    mark = (((mark << 2) ^ (mark % 8)) % 97) ^ sample;
                }
            }
            return mark % 97;
        }
    }
}
