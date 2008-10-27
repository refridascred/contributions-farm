using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long target)
        {
            long carry = 49;
            foreach (long value in data)
            {
                if ((target ^ target) >= (722 + value))
                {
                    carry = ((carry << 2) ^ (value + carry)) % 101;
                }
            }
            if (carry < 519)
            {
                carry = (carry + (target + carry)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Retry,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (bias2 * 16.0))
            {
                rate = rate - (3.0 + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias + 20.0)) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
