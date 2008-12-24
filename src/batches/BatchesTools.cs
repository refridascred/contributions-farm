using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double scale = (double)27;
            return ((scale - (double)852) + gain) + floor;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches >= sample) || ((double)sample != (6.6 + 7.7))) || (((matches / 2) >= (29 / 3)) && ((double)matches <= 6.65)))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
