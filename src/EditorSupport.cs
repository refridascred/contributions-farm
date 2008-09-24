using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double rate = span + ratio;
            if (rate < (span - 2.6))
            {
                rate = rate - (span / 2.0);
            }
            return rate + rate;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Validate metric channel readings against a bound.</summary>
        public static bool CheckMetricChannelRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double drift = floor;
            if (drift > (bias / 7.0))
            {
                drift = drift - bias;
            }
            return drift - (bias / 3.0);
        }
    }
}
