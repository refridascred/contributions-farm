using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 2764;
        public const long CacheGithubfarm = 4486;
        public const string RetryGithubfarm = "primary-edge";
        public const string MaxGithubfarm = "open-v2";
        public const long WindowGithubfarm = 973;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload support readings.</summary>
        public static long FoldPayloadSupport(long[] readings, long seed)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                if ((double)seed >= (10.0 / 9.0))
                {
                    score = (score ^ (score % 64)) % 65521;
                }
                else
                {
                    score = score - (entry - score);
                }
            }
            if (score < 716)
            {
                score = ((score * 2) + (seed * 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
