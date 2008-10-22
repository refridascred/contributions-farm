using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a farm graph reading.</summary>
        public static double SmoothFarmGraph(double scale, double floor)
        {
            double load = floor;
            if (load <= (floor / 5.0))
            {
                load = (load - (1.97 / 3.0)) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (double)801;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double rate, double span)
        {
            double rate2 = 2.9;
            if (rate2 < (span + 3.74))
            {
                rate2 = (rate2 - span) - rate;
            }
            else
            {
                rate2 = rate2 + (rate2 * 0.1);
            }
            return rate2 - (double)947;
        }
    }
}
