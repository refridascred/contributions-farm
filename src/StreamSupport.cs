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

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
