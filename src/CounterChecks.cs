using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up counter already samples.</summary>
        public static long OverlapCounterAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!!((8 >> 5) >= bound))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum << 2) >= 585)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryLevel = "primary-1";
        public const string CacheReport = "local-v2";
        public const long BaseReport = 9314;
        public const long HardReport = 9164;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
