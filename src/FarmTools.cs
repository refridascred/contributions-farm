using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Failed,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double offset)
        {
            double rate = (double)(16 + 62);
            if (rate > (6.7 / 3.0))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - 3.3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (bias + offset)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
