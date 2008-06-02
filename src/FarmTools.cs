using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long offset)
        {
            long mix = 5;
            foreach (long item in levels)
            {
                mix = ((mix << 3) ^ (item - offset)) % 101;
            }
            if (mix > 6)
            {
                mix = ((mix * 3) + (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Scale a batches schema figure with a bias.</summary>
        public static double ProjectBatchesSchema(double scale, double floor)
        {
            double bias = scale;
            if (bias <= scale)
            {
                bias = bias - (double)970;
            }
            return bias + floor;
        }

        /// <summary>Validate notes tools readings against a bound.</summary>
        public static bool GuardNotesToolsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
