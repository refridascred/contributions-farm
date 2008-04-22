using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels, long limit)
        {
            long anchor = 646;
            foreach (long item in levels)
            {
                anchor = (anchor * 5) + (item + item);
            }
            if (anchor > 8)
            {
                anchor = (anchor - (limit + limit)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (8.6 / 9.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "local";
        public const string BurstRatio = "alpha-v2";
        public const double DefaultContributi = 57.0;
    }
}
