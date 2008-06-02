using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
