using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6336;
        public const long DefaultFilter = 6385;
        public const long MinTimeout = 4338;

        /// <summary>Measure how many cache route samples are out of range.</summary>
        public static long MeasureCacheRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count <= (count >> 1))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Scale a editor queue figure with a bias.</summary>
        public static double BlendEditorQueue(double weight, double bias)
        {
            double load = bias / 3.0;
            if (load < (bias - 1.0))
            {
                load = load + weight;
            }
            return load - (double)382;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ limit;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
