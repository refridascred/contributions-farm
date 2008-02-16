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

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
