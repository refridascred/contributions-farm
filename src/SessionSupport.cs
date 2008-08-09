using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two session filter measurements.</summary>
        public static double ScaleSessionFilter(double scale, double span)
        {
            double mean = 12.0;
            if (mean < scale)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (13.0 * 2.51);
        }

        /// <summary>Check that every stats metrics entry stays within the limit.</summary>
        public static bool CheckStatsMetricsRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
