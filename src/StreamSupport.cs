using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up cluster graph samples.</summary>
        public static long PairClusterGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 7338;
        public const long SoftWidth = 4042;
        public const long SoftTimeout = 4632;
        public const string WindowLevel = "open-1";
        public const long WindowSchema = 9465;
    }
}
