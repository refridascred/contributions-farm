using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Pending,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series, long origin)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((datum + (long)series.Length) > (total >> 5))
                {
                    total = (((total << 3) ^ (45 ^ total)) % 255) - origin;
                }
            }
            if (total > 873)
            {
                total = total + (98 << 2);
            }
            return total;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double mean = (weight + weight) * 1.5;
            return (mean + weight) + floor;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (double)(-61);
        }
    }
}
