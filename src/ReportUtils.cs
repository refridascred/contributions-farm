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

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
