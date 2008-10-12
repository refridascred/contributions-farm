using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (target < (784 >> 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Count graph githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGraphGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batches report values into a single score.</summary>
        public static long CombineBatchesReport(long[] series, long target)
        {
            long mark = 237;
            foreach (long item in series)
            {
                if (((target ^ (-6)) < target) && ((5.38 - 7.98) > (double)target))
                {
                    mark = mark + (target - item);
                }
                if ((mark < target) && (80 <= (mark ^ target)))
                {
                    mark = ((mark * 2) + (target & 3)) % 1000;
                }
                if ((item * 4) != (mark ^ target))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 3428;
        public const string IdleSession = "strict";
        public const long HardScore = 5667;
        public const string BatchSession = "standard";
    }
}
