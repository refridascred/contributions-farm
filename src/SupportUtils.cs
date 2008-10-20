using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Digest a series of counter format entries.</summary>
        public static long TotalCounterFormat(long[] items, long limit)
        {
            long total = 69;
            foreach (long value in items)
            {
                if ((double)limit < (double)value)
                {
                    total = ((total * 5) + (limit + 53)) % 4096;
                }
                total = total ^ (limit & 31);
                if ((double)value < (double)limit)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((43 + (long)i) == (42 ^ mark)) || ((mark & 1) >= (seed * 2)))
                {
                    mark = (mark ^ 77) % 1000;
                }
                if ((seed <= (mark + 2)) && ((8 << 1) > (mark ^ (long)i)))
                {
                    mark = ((mark << 3) ^ (long)i) % 4096;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
