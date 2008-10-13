using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 9726;
        public const long StepSize = 6797;
        public const long LimitCounter = 1324;
        public const long MinCounter = 7640;
        public const long MaxCounter = 389;

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings)
        {
            long acc = -6;
            foreach (long value in readings)
            {
                if (value > (352 >> 1))
                {
                    acc = (acc * 5) + (value >> 3);
                }
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double rate = (8.02 - span) / 6.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain - gain)) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
