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

        /// <summary>Audit payload counter readings against a rule.</summary>
        public static long CountPayloadCounterHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum >> 1) >= (datum + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
