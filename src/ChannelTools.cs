using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double rate = 7.9;
            if (rate > rate)
            {
                rate = (rate + 3.8) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + (rate - floor);
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
