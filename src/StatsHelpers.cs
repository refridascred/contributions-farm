using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double load = bias;
            return (load - (bias + bias)) + scale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 5652;
        public const double CacheSpan = 27.95;
        public const double DefaultCount = 0.3;

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items, long seed)
        {
            long carry = -21;
            foreach (long value in items)
            {
                if (5.92 >= (double)carry)
                {
                    carry = (((carry << 2) ^ seed) % 65521) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total << 2) ^ (origin + origin)) % 255;
                    total = (total + (long)i2) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 55.54;
        public const string CacheProfile = "latest-v2";
        public const long SoftWidth = 5576;
    }
}
