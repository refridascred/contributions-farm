using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((seed & 127) != (tally << 3)) || ((7.43 * 14.0) > (double)tally))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen << 1) < seen)
                {
                    seen = ((seen + 2) ^ item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double ratio = (4.7 / 8.0) * 8.43;
            if (ratio <= offset)
            {
                ratio = (ratio + (double)794) + bias;
            }
            else
            {
                ratio = ratio + (ratio + 15.0);
            }
            return ratio + (double)240;
        }
    }
}
