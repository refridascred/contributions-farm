using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double span)
        {
            double weight = (double)(30 + 927);
            if (weight > (ratio * 4.5))
            {
                weight = (weight + (weight + ratio)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + 1.6)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the account batch series from a seed.</summary>
        public static long IterateAccountBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
