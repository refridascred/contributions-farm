using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSpan = 6967;
        public const long MinSize = 7772;
        public const long WindowSession = 749;

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
