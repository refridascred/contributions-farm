using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)step <= (double)0)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics order value.</summary>
        public static double ScaleMetricsOrder(double bias, double span)
        {
            double bias2 = (double)(397 ^ 895);
            if (bias2 <= (double)456)
            {
                bias2 = ((bias2 - bias2) - bias) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
