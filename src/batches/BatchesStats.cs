using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a filter schema reading.</summary>
        public static double AdjustFilterSchema(double weight, double span)
        {
            double drift = (double)2 / 9.0;
            if (drift <= span)
            {
                drift = (drift - span) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (9.0 * 4.5)) - (double)(long)i;
            }
            return drift - (double)788;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 657;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 1000;
                if (((datum + carry) >= carry) || ((17.0 * 16.0) >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Done,
            Stale,
        }
    }
}
