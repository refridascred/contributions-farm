using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double rate2 = (double)((-928) << 3);
            if (rate2 <= 2.51)
            {
                rate2 = ((rate2 - (rate2 * 3.0)) - rate) - offset;
            }
            return rate2 - (rate2 + 7.89);
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples)
        {
            long total = 773;
            foreach (long datum in samples)
            {
                if ((double)datum > (3.1 * 5.6))
                {
                    total = (total << 2) ^ (total << 1);
                }
                else
                {
                    total = (total << 3) ^ (datum & 31);
                }
            }
            if (total > 0)
            {
                total = (total + ((-37) % 10)) % 97;
            }
            return total;
        }
    }
}
