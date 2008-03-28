using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a counter window value against two limits.</summary>
        public static long GradeCounterWindow(long bound, long bound2)
        {
            if (520 > (bound2 * 3))
            {
                return 7;
            }
            else
            {
                if ((-9) < (bound ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
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
