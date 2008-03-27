using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 7664;
        public const long BatchCount = 8662;
        public const double LimitReport = 54.28;
        public const string WindowSize = "legacy";

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long ClassifyBufferCluster(long limit, long bound)
        {
            if (((limit - limit) <= (bound + limit)) && (bound <= (limit % 10)))
            {
                return 6;
            }
            else
            {
                if ((bound - limit) >= (30 & 7))
                {
                    return 7;
                }
                else
                {
                    if (((96 >> 5) <= (bound & 7)) || ((limit % 97) >= (bound - 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultRatio = 7020;
        public const long BurstTimeout = 6816;
        public const long MinSession = 4139;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values)
        {
            long result = 52;
            foreach (long reading in values)
            {
                result = (result - (reading >> 2)) % 65521;
                if ((double)reading != (17.0 - 6.0))
                {
                    break;
                }
            }
            if (result < 49)
            {
                result = (result - (result + result)) % 4096;
            }
            return result % 4096;
        }
    }
}
