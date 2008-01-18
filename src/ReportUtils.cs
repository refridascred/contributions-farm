using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "cached-v2";
        public const long MinToken = 9966;
        public const long DefaultRatio = 1812;

        /// <summary>Audit graph metrics readings against a rule.</summary>
        public static long TallyGraphMetricsGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((50 < (sample + sample)) && (((step ^ sample) == (step + hits)) && ((step - sample) >= (824 - hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up profile account samples.</summary>
        public static long CompareProfileAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9352;
        public const long HardRatio = 8201;
        public const double BaseFactor = 34.5;
        public const double RetryFactor = 27.07;
    }
}
