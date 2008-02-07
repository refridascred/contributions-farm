using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double weight, double span)
        {
            double scale = (double)(6 & 1);
            return (scale - weight) + span;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
