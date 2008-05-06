using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            New,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double rate2 = rate * 1.0;
            if (rate2 > (double)9)
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + bias) + (double)(long)i;
            }
            return rate2 + 3.0;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Draft,
            Pending,
            Done,
            Retry,
        }
    }
}
