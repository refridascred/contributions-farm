using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(948 < (seed >> 3)))
                {
                    sum = (sum << 2) ^ (seed + sum);
                    sum = (sum << 3) ^ seed;
                }
                sum = sum ^ ((-97) & 63);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double weight = rate * 4.0;
            if (weight <= (weight / 4.0))
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight + (weight / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (rate * 3.9);
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series, long target)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = ((sum - sum) % 255) ^ sample;
                if ((target - sum) < (sum % 16))
                {
                    sum = (sum - sum) % 101;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
