using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1413;
        public const long MaxRoute = 4298;
        public const long IdleRoute = 7443;

        /// <summary>Adjust a payload support reading.</summary>
        public static double BlendPayloadSupport(double gain, double floor)
        {
            double scale = (4.36 - floor) / 7.0;
            if (scale > 5.28)
            {
                scale = (scale + 7.8) + gain;
            }
            return scale - (scale + scale);
        }
    }
}
