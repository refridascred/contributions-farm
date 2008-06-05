using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values)
        {
            long acc = 1;
            foreach (long value in values)
            {
                acc = ((acc * 3) + (551 + acc)) % 101;
                if ((acc - value) <= 7)
                {
                    acc = ((acc * 5) + (value + value)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double ratio = bias;
            return ratio + (span + bias);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
