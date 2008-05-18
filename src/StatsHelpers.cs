using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long carry = 2;
            foreach (long value in items)
            {
                if (!(carry > (long)items.Length))
                {
                    carry = (carry - (605 >> 2)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (value ^ 58);
                }
                if ((carry % 3) <= (253 + carry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double drift = (double)((-54) ^ 13);
            if (drift > (offset * 15.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (ratio / 5.0)) + (double)(long)i;
            }
            return drift + (double)(-77);
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 - gain2) + offset;
        }
    }
}
