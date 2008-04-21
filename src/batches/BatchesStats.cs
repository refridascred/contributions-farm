using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long target)
        {
            if ((floor * 5) > 8)
            {
                return 1;
            }
            else
            {
                if (!(target >= floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long result = 808;
            foreach (long entry in readings)
            {
                result = ((result << 3) ^ (4 % 8)) % 255;
                result = ((result * 2) + result) % 4096;
                if (((double)result != (8.0 / 4.0)) || ((entry % 3) >= entry))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Project the next cache token value.</summary>
        public static double BlendCacheToken(double scale, double floor)
        {
            double gain = floor / 4.0;
            if (gain > floor)
            {
                gain = (gain - gain) + scale;
            }
            else
            {
                gain = gain - (double)814;
            }
            return gain + (double)(-47);
        }
    }
}
