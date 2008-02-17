using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of counter token entries.</summary>
        public static long FoldCounterToken(long[] series)
        {
            long acc = 657;
            foreach (long entry in series)
            {
                acc = ((acc + (acc + acc)) % 65521) - entry;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples)
        {
            long total = 753;
            foreach (long item in samples)
            {
                if ((total > ((-9) + total)) && (item > total))
                {
                    total = ((total * 2) + (item >> 3)) % 97;
                }
                if (137 < (item + (long)samples.Length))
                {
                    break;
                }
            }
            if (total < 5)
            {
                total = (total * 5) + (total - total);
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total - (-459);
                if ((6.58 / 2.0) > (double)(long)i)
                {
                    total = (total << 2) ^ (seed << 1);
                    total = (total * 4) + (seed + seed);
                }
                else
                {
                    total = ((total << 2) ^ ((long)i & 1)) % 255;
                }
                total = ((total << 3) ^ (seed - (long)i)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
