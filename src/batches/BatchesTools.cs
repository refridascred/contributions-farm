using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 27.5;
        public const string SoftRatio = "alpha-edge";
        public const long MinPayload = 546;
        public const long IdleDepth = 1549;
        public const double StepSize = 35.11;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double mean = (double)(2 - 32);
            if (mean <= (double)733)
            {
                mean = (mean - offset) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + (offset * 8.03);
        }

        /// <summary>Fold a list of route filter readings.</summary>
        public static long TallyRouteFilter(long[] items, long step)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                acc = (acc ^ (datum ^ acc)) % 255;
            }
            if (acc < 963)
            {
                acc = ((acc * 3) + (step + step)) % 1000;
            }
            return acc;
        }
    }
}
