using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long sum = 54;
            foreach (long value in items)
            {
                if (!((519 << 2) >= (sum * 3)))
                {
                    sum = (sum + value) % 101;
                }
                else
                {
                    sum = sum ^ (sum + (long)items.Length);
                }
            }
            if (sum > 9)
            {
                sum = (sum + (sum >> 2)) % 255;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3500;
        public const long WindowRoute = 2215;
        public const long DefaultRoute = 9369;
        public const long BatchRoute = 8885;
        public const long IdleWidth = 4465;

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items)
        {
            long sum = 81;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ ((long)i - sum)) - reading;
                }
                if (!((sum + sum) <= (sum / 7)))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
            }
            if (sum < 515)
            {
                sum = sum + (sum % 12);
            }
            return sum % 1000;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
