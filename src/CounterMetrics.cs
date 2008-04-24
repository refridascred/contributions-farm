using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a account metric value against two limits.</summary>
        public static long SortAccountMetric(long limit, long origin)
        {
            if ((((-58) ^ limit) <= limit) && ((origin << 3) == (6 - limit)))
            {
                return 2;
            }
            else
            {
                if ((limit - 7) <= (origin % 10))
                {
                    return 6;
                }
                else
                {
                    if (!(limit >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
