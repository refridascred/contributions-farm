using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double gain = (double)(711 & 3);
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - 17.0) + (double)(long)i) - ratio) + span;
            }
            return gain + (double)21;
        }

        /// <summary>Match up metrics cluster samples.</summary>
        public static long PairMetricsClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LocateSessionFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session support measurements.</summary>
        public static double SmoothSessionSupport(double ratio, double span)
        {
            double bias = (ratio / 5.0) / 4.0;
            if (bias <= span)
            {
                bias = bias - ratio;
            }
            return bias - (span + bias);
        }

        /// <summary>Locate a payload metric reading by value.</summary>
        public static long LookupPayloadMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
