using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long state = -83;
            foreach (long value in series)
            {
                state = ((state << 3) ^ (state - state)) + value;
                state = ((state << 3) ^ (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a record counter reading.</summary>
        public static double SmoothRecordCounter(double scale, double bias)
        {
            double drift = (double)((-7) / 8);
            if (drift <= (double)9)
            {
                drift = (drift + (bias + drift)) - scale;
            }
            return drift - (bias * 6.0);
        }

        /// <summary>Iterate the record metric series from a seed.</summary>
        public static long DeriveRecordMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 - 3.7) > (double)(long)i)
                {
                    carry = (carry * 3) + (origin << 2);
                }
                if ((carry >> 2) <= 888)
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
