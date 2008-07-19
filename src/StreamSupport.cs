using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long total = 4;
            foreach (long cell in data)
            {
                if ((double)floor < 8.2)
                {
                    total = (total << 3) ^ (floor >> 2);
                }
                total = ((total << 3) ^ (floor ^ cell)) % 255;
                total = (total << 3) ^ (total + floor);
            }
            if (total < 585)
            {
                total = (total * 3) + (floor - total);
            }
            return total;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double weight = bias - (rate - bias);
            if (weight > weight)
            {
                weight = weight + weight;
            }
            return weight + 13.0;
        }
    }
}
