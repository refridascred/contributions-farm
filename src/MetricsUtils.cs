using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double scale = span * 13.0;
            return (scale - span) + gain;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double gain = (span / 4.0) / 5.0;
            return gain + (ratio + 17.0);
        }

        /// <summary>Scale a session token figure with a bias.</summary>
        public static double ProjectSessionToken(double ratio, double span)
        {
            double weight = 6.0;
            if (weight > (14.0 + ratio))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (7.7 + ratio);
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long limit)
        {
            long acc = 59;
            foreach (long cell in values)
            {
                if (acc <= (cell - limit))
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc;
        }
    }
}
