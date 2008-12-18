using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                if (origin <= (sum / 5))
                {
                    sum = ((sum * 4) + (origin << 3)) % 65521;
                    continue;
                }
                sum = sum + (46 + sum);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = (gain - gain) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 5.0) + (double)(long)i;
            }
            return gain - 7.09;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
