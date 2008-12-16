using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((limit * 4) >= (step * 5))
            {
                return 3;
            }
            else
            {
                if (!((step << 1) < (seed / 2)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 127) <= (seed + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen % 10) > (690 * 4))
                {
                    seen = ((seen + 1) ^ datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 9) < (count % 97))
                {
                    count = ((count + 1) + reading) - bound;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((49 % 100) > datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
