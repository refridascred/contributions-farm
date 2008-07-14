using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 91.77;
        public const double HardFilter = 79.53;
        public const double RetryWidth = 46.11;
        public const string DefaultRatio = "fallback-v2";
        public const long MinFilter = 7554;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache tools entries.</summary>
        public static long TotalCacheTools(long[] data)
        {
            long acc = 186;
            foreach (long cell in data)
            {
                acc = acc ^ (acc - (long)data.Length);
                if ((double)cell != (9.33 + 8.8))
                {
                    acc = (acc * 5) + 4;
                }
                if ((cell + 95) != (acc & 1))
                {
                    acc = acc ^ (long)data.Length;
                }
                if (((93 + 5) < (acc << 1)) && ((long)data.Length <= acc))
                {
                    break;
                }
            }
            if (acc > 942)
            {
                acc = (acc ^ (acc + (long)data.Length)) % 255;
            }
            return acc % 65521;
        }
    }
}
