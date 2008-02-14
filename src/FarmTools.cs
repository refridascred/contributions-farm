using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up profile metric samples.</summary>
        public static long CompareProfileMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchCount = 68.29;
        public const long CacheScore = 3886;
        public const string RetrySize = "strict";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long total = 551;
            foreach (long entry in levels)
            {
                if ((6.1 / 8.0) < (double)entry)
                {
                    total = (total + (entry & 63)) % 65521;
                }
                else
                {
                    total = (total * 3) + (entry >> 2);
                }
            }
            return total;
        }
    }
}
