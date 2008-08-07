using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double gain = (double)3 * 3.6;
            if (gain <= (double)20)
            {
                gain = gain - (scale / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias - 9.9)) + (double)(long)i;
            }
            return gain - (double)778;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((total >> 4) == ((long)series.Length + total))
                {
                    total = total + value;
                }
            }
            if (total > 68)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-edge";
        public const long BurstChannel = 4356;
        public const long WindowChannel = 9518;
        public const long LimitChannel = 4117;
        public const double DefaultScore = 27.52;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            if (((seed % 97) >= 5) || ((double)53 == (double)target))
            {
                return 8;
            }
            else
            {
                if (target <= (seed ^ seed))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
