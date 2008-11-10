using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double bias, double span)
        {
            double mean = 16.0 + (bias + bias);
            if (mean >= (bias * 0.17))
            {
                mean = mean - (bias - span);
            }
            return mean - (double)48;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double drift = gain;
            if (drift > (gain - span))
            {
                drift = drift - (span / 5.0);
            }
            else
            {
                drift = drift - 7.56;
            }
            return drift - drift;
        }
    }
}
