using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double rate = (double)90 + bias;
            if (rate < bias)
            {
                rate = rate - 9.2;
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate * 5.0)) + (double)(long)i;
            }
            return rate + (bias / 5.0);
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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((6 & 31) == (datum - 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
