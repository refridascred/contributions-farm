using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Blend two tools notes measurements.</summary>
        public static double ProjectToolsNotes(double scale, double span)
        {
            double ratio = (double)(-2) / 3.0;
            if (ratio <= (6.48 * 1.49))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio + 9.67;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
