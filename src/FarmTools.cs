using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 89.32;
        public const string WindowCount = "standard-edge";
        public const long BurstWidth = 2669;

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double mean = floor;
            return (mean + mean) + scale;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long target)
        {
            if ((52 <= (step / 6)) || ((target >> 3) == (35 / 5)))
            {
                return 8;
            }
            else
            {
                if ((double)step > 3.97)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
