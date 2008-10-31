using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total ^ seed;
                    total = (total - ((long)i2 + total)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of cache session entries.</summary>
        public static long DigestCacheSession(long[] series, long seed)
        {
            long total = 985;
            foreach (long datum in series)
            {
                if (!!((double)datum <= (16.0 + 0.3)))
                {
                    total = total ^ (0 >> 4);
                }
                if ((total / 5) != (datum + seed))
                {
                    total = ((total * 4) + (total + 90)) % 4096;
                }
                else
                {
                    total = ((total * 3) + (total << 3)) % 4096;
                }
                if (((seed & 31) >= datum) && ((1 << 3) > seed))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Retry,
            Locked,
        }
    }
}
