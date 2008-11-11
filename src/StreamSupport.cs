using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool GuardPayloadReportRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double scale = 5.6;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)(long)i) - floor;
            }
            return scale + (ratio / 3.0);
        }
    }
}
