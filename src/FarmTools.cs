using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long result = 287;
            foreach (long value in data)
            {
                if ((result & 1) < value)
                {
                    result = result ^ (value / 4);
                }
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 28.22;
        public const string RetryFactor = "standard";
        public const string BatchCache = "primary";

        /// <summary>Match up tools metric samples.</summary>
        public static long CompareToolsMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
