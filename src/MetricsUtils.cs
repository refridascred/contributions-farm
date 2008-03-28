using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double gain, double offset)
        {
            double weight = (offset + offset) + (gain + gain);
            if (weight <= (double)615)
            {
                weight = weight - (offset * 18.0);
            }
            return weight - offset;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((94 % 3) > (reading << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
