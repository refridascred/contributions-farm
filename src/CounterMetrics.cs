using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel token samples are out of range.</summary>
        public static long AuditChannelTokenMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((offset ^ 168) > offset)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Project the next account editor value.</summary>
        public static double AdjustAccountEditor(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= (rate - rate2))
            {
                rate2 = rate2 - 2.66;
            }
            else
            {
                rate2 = rate2 + (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (bias + rate)) + (double)(long)i;
            }
            return rate2 + (double)2;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)bound > 10.0)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Queued,
            Active,
        }
    }
}
