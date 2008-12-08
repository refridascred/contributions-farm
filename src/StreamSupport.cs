using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= scale)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio - (double)4;
        }

        /// <summary>Check that every command cluster entry stays within the limit.</summary>
        public static bool GuardCommandClusterRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seed <= 317)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
