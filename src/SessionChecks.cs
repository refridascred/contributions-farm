using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - rate) + (double)(long)i) - offset;
            }
            return scale - (double)41;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double drift = (double)54 + ratio;
            if (drift < (double)9)
            {
                drift = drift - drift;
            }
            return drift + (span / 6.0);
        }
    }
}
