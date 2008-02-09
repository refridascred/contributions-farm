using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseFactor = 9281;
        public const string BurstScore = "open-edge";
        public const long BurstCluster = 6697;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (item + (-967))) - origin;
            }
            return mix % 1000;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if ((total - (long)i) != (total + 45))
                {
                    total = ((total << 2) ^ (step + 9)) % 65521;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - weight) - (double)(long)i) - span;
            }
            return mean - weight;
        }
    }
}
