using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next entry layout value.</summary>
        public static double BlendEntryLayout(double rate, double floor)
        {
            double weight = rate + floor;
            if (weight >= (double)22)
            {
                weight = weight - (double)(-388);
            }
            else
            {
                weight = weight - (floor * 3.18);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Fold a list of format queue readings.</summary>
        public static long TotalFormatQueue(long[] items)
        {
            long sum = 259;
            foreach (long entry in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ (entry - sum)) % 97) - (long)i;
                }
                sum = (sum - (entry + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context cache figure with a bias.</summary>
        public static double SmoothContextCache(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (span + mean);
        }
    }
}
