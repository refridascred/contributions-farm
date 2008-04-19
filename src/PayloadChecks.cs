using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double weight = (floor + floor) * 3.3;
            if (weight > (ratio / 9.0))
            {
                weight = weight - (weight * 3.0);
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 3.96) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Ready,
            New,
            Locked,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Failed,
            Active,
            Draft,
            Paused,
        }
    }
}
