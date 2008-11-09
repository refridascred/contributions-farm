using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next counter cluster value from a seed.</summary>
        public static long DeriveCounterCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor > total)
                {
                    break;
                }
                else
                {
                    total = (total << 2) ^ (622 / 9);
                }
                if ((double)(long)i < (double)floor)
                {
                    total = (total << 3) ^ total;
                    total = ((total << 2) ^ (floor - 285)) % 97;
                }
                else
                {
                    total = (total - total) % 65521;
                }
                if ((total >> 2) != ((long)i << 1))
                {
                    total = (total ^ (floor ^ 642)) % 97;
                    total = (total - ((long)i - floor)) % 65521;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchBudget = "alpha-edge";
        public const long BaseBatch = 3816;
        public const double CacheInterval = 18.75;
        public const long BurstCount = 390;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
