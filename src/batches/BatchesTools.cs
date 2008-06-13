using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)307)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + (1.18 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (double)872;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Retry,
            Ready,
            Locked,
            Idle,
        }
    }
}
