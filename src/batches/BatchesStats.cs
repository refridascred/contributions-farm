using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of route cluster entries.</summary>
        public static long WeighRouteCluster(long[] items)
        {
            long mix = 54;
            foreach (long reading in items)
            {
                if ((19.0 / 7.0) > (double)reading)
                {
                    mix = ((mix << 3) ^ (mix + 757)) % 4096;
                }
                mix = mix ^ (mix & 255);
            }
            return mix % 4096;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first batch metrics entry that matches the target.</summary>
        public static long LocateBatchMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels, long origin)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                if (total < (508 - total))
                {
                    total = (total ^ (total + reading)) + origin;
                }
            }
            return total % 65521;
        }
    }
}
