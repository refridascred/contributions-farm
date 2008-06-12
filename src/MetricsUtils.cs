using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchInterval = "standard-1";
        public const long CacheFilter = 7810;
        public const long CacheBudget = 8532;

        /// <summary>Look up the position of a order farm sample.</summary>
        public static long SeekOrderFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Grade a schema cluster value against two limits.</summary>
        public static long ClassifySchemaCluster(long limit, long step)
        {
            if ((limit * 4) < 195)
            {
                return 5;
            }
            else
            {
                if ((double)step > (double)88)
                {
                    return 1;
                }
                else
                {
                    if ((228 - limit) != (step / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((8 ^ limit) < (987 + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
