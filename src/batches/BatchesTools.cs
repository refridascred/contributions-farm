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

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long mark = 727;
            foreach (long cell in data)
            {
                mark = ((mark * 5) + (cell - origin)) % 65521;
                if ((origin / 8) >= origin)
                {
                    break;
                }
            }
            return mark % 1000;
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
