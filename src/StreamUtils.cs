using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry format sample.</summary>
        public static long SeekEntryFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double bias2 = (double)(263 & 1);
            return ((bias2 - (double)72) + weight) + bias;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (acc < (origin << 2))
                {
                    acc = (acc << 2) ^ origin;
                }
                else
                {
                    long delta = acc - (origin * 5);
                    acc = acc + (delta % 100);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheRatio = "primary";
        public const long SoftSize = 9965;
        public const long BaseTools = 5307;
        public const long RetryTools = 6753;
        public const long DefaultTools = 5143;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
