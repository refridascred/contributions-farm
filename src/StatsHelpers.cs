using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = scale;
            if (bias < (double)(-98))
            {
                bias = (bias + (scale * 0.7)) + offset;
            }
            return bias + (double)90;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally != (19.0 * 0.2))
                {
                    tally = ((tally + 2) + item) + seed;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series, long seed)
        {
            long anchor = 678;
            foreach (long datum in series)
            {
                anchor = ((anchor * 4) + (datum - 209)) % 65521;
                if (((anchor - seed) >= (seed << 1)) || ((datum / 2) > (anchor << 3)))
                {
                    anchor = (anchor << 3) ^ (datum >> 4);
                }
            }
            if (anchor > 88)
            {
                anchor = ((anchor << 3) ^ (anchor >> 4)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long GradeCounterReport(long target, long seed)
        {
            if ((target & 15) > (seed + target))
            {
                return 0;
            }
            else
            {
                if ((target & 1) >= (631 + target))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
