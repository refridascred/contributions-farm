using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double drift = (double)8;
            if (drift > span)
            {
                drift = (drift - span) - bias;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
