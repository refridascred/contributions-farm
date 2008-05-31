using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseWidth = 30.42;
        public const string LimitFarm = "staging";
        public const double BatchFarm = 0.14;

        /// <summary>Grade a record editor value against two limits.</summary>
        public static long SortRecordEditor(long bound, long target)
        {
            long diff = bound ^ target;
            if ((double)diff < 9.6)
            {
                return 6;
            }
            else
            {
                if ((diff + bound) > (diff / 9))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double span)
        {
            double drift = 3.0;
            if (drift >= (double)85)
            {
                drift = ((drift - (double)61) - scale) + span;
            }
            return drift + (drift * 20.0);
        }
    }
}
