using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Adjust a buffer metric reading.</summary>
        public static double ProjectBufferMetric(double bias, double span)
        {
            double rate = span;
            if (rate < bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (bias - span)) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
