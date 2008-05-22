using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double weight = (bias - 14.0) / 5.0;
            return (weight - (bias / 6.0)) + scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleInterval = 8285;
        public const long WindowWidth = 2208;
        public const double WindowRatio = 64.26;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                long count = ((long)i - 86) + (bound - bound);
                if ((count + acc) > (172 - acc))
                {
                    count = ((count << 3) ^ ((long)i + 0)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
