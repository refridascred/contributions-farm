using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double gain = (double)(183 & 63);
            return (gain - (gain - weight)) + floor;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool ValidateFormatFilterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
