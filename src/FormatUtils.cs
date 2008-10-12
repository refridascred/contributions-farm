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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 5765;
        public const long IdleOrder = 3360;
        public const long BaseInterval = 7742;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 3428;
        public const string IdleSession = "strict";
        public const long HardScore = 5667;
        public const string BatchSession = "standard";
    }
}
