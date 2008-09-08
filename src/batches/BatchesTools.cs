using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double scale = 9.7;
            if (scale > scale)
            {
                scale = (scale - offset) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 12.0) - (double)(long)i;
            }
            return scale - (double)73;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long origin)
        {
            long result = 719;
            foreach (long entry in values)
            {
                if (!((result + 478) != (origin ^ result)))
                {
                    result = (((result * 3) + (result % 100)) % 1000) - entry;
                }
            }
            if (result < 40)
            {
                result = ((result * 4) + result) % 101;
            }
            return result;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Idle,
            New,
            Stale,
            Active,
        }
    }
}
