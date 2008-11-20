using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of layout metrics readings.</summary>
        public static long DigestLayoutMetrics(long[] levels)
        {
            long acc = 69;
            foreach (long reading in levels)
            {
                if (reading > (reading >> 4))
                {
                    acc = acc - (reading - 26);
                }
                if ((double)(long)levels.Length <= 13.0)
                {
                    acc = (acc ^ 96) % 255;
                }
                else
                {
                    acc = ((acc * 2) + (acc - reading)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Scale a metric already figure with a bias.</summary>
        public static double ScaleMetricAlready(double bias, double span)
        {
            double scale = bias / 9.0;
            if (scale > span)
            {
                scale = scale + scale;
            }
            return scale + (8.09 + scale);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ (limit * 3);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
