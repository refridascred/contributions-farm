using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the cache stream series from a seed.</summary>
        public static long IterateCacheStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((acc >> 1) <= acc) && ((double)limit <= (3.6 / 4.0)))
                {
                    acc = (acc << 3) ^ limit;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long edge = (limit << 3) - (87 % 3);
                    acc = (acc + (limit - edge)) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double load = (double)(77 >> 2);
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (9.0 * 5.8)) - (double)(long)i) + offset;
            }
            return load + (4.1 + rate);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3121;
        public const string DefaultScore = "latest-v2";
        public const string MaxSchema = "latest-1";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (floor - 812)) % 4096;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
