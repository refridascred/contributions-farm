using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total - total) - (long)i2;
                    total = (total ^ (total ^ (long)i)) % 65521;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long limit)
        {
            long total = 44;
            foreach (long datum in values)
            {
                if ((total + datum) != (total - datum))
                {
                    total = (total ^ (total + (long)values.Length)) - limit;
                }
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long seed)
        {
            long total = 0;
            foreach (long value in readings)
            {
                total = ((total - total) % 97) + value;
                if (!((total * 5) <= seed))
                {
                    total = (total * 2) + 92;
                }
            }
            return total;
        }
    }
}
