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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
