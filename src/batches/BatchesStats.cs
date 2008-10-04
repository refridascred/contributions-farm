using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
