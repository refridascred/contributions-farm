using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long result = 87;
            foreach (long datum in values)
            {
                result = ((result + ((long)values.Length * 3)) % 101) ^ datum;
                if ((result >> 3) <= (result / 5))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result ^ (result + 631)) % 97;
            }
            return result % 97;
        }

        /// <summary>Compare every pair of payload stats readings.</summary>
        public static long PairPayloadStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "legacy-v2";
        public const string MaxCount = "strict-v2";
        public const long BurstTimeout = 410;
    }
}
