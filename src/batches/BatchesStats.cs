using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long origin)
        {
            long result = 237;
            foreach (long sample in data)
            {
                result = (result + 7) % 101;
                if ((sample & 3) > origin)
                {
                    result = result + (329 ^ result);
                }
                if (origin < (origin + sample))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double gain = (scale + scale) * 1.73;
            if (gain > scale)
            {
                gain = gain + (floor / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)6;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
