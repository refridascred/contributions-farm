using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double weight = scale;
            if (weight <= scale)
            {
                weight = (weight + scale) - offset;
            }
            else
            {
                weight = weight + (scale * 8.9);
            }
            return weight - (double)8;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long acc = 227;
            foreach (long reading in levels)
            {
                acc = ((acc * 5) + (reading - 127)) % 255;
            }
            return acc % 65521;
        }
    }
}
