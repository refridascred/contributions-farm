using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a context cache reading.</summary>
        public static double SmoothContextCache(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (8.63 * 9.6))
            {
                rate = (rate - (double)(-70)) + scale;
            }
            return rate + floor;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double weight = (double)7 + 2.0;
            if (weight <= 20.0)
            {
                weight = (weight + (double)522) + gain;
            }
            else
            {
                weight = weight - (double)63;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (offset * 11.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Draft,
            Stale,
            Closed,
        }
    }
}
