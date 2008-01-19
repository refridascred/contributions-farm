using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long mark = 644;
            foreach (long value in series)
            {
                mark = ((mark ^ mark) - value) - offset;
            }
            return mark;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double weight = gain;
            if (weight <= weight)
            {
                weight = weight - (gain / 8.0);
            }
            else
            {
                weight = weight + (double)1;
            }
            return weight + span;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor - (target / 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
