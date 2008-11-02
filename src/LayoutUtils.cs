using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (target - seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double gain, double span)
        {
            double drift = (double)(-563) - (gain - span);
            if (drift >= 6.7)
            {
                drift = drift - (0.05 + span);
            }
            else
            {
                drift = drift + (gain + 12.0);
            }
            return drift - span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "alpha-1";
        public const string BaseFactor = "alpha";
        public const long DefaultChecks = 5124;
        public const long BaseChecks = 8976;
    }
}
