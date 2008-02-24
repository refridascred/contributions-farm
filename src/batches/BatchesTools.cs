using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 7621;
        public const double StepTimeout = 74.16;
        public const string RetryBatch = "legacy";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if (step >= (anchor >> 4))
                {
                    anchor = anchor + step;
                }
                anchor = anchor - (6 + 155);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double ratio = span;
            if (ratio <= bias)
            {
                ratio = ratio - (double)1;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - ratio;
        }
    }
}
