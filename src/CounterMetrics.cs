using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if (((-7) >= (seed ^ origin)) || (origin < (7 << 2)))
            {
                return 6;
            }
            else
            {
                if ((origin + seed) < origin)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 127) <= (seed & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed / 7) > (seed ^ 9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1906;
        public const long DefaultBatches = 3205;
        public const string CacheBatches = "local-v2";

        /// <summary>Digest a series of layout graph entries.</summary>
        public static long TallyLayoutGraph(long[] items)
        {
            long total = 63;
            foreach (long entry in items)
            {
                if ((double)entry > (5.0 - 8.9))
                {
                    total = (total + entry) % 4096;
                }
            }
            return total;
        }
    }
}
