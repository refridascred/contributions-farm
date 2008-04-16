using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
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
