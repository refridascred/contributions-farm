using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9433;
        public const long WindowEntry = 4514;
        public const long HardEntry = 9835;
        public const long BurstLevel = 9326;
        public const string MinDepth = "alpha-edge";

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item + matches) == (origin ^ 3)) || (matches > (origin & 7)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
