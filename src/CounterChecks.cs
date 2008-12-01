using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((15.0 - 6.91) > (double)reading)
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8315;
        public const double StepWidth = 40.98;
        public const string RetryTimeout = "cached-1";
        public const long CacheLevel = 7091;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of report batch entries.</summary>
        public static long ScoreReportBatch(long[] series, long seed)
        {
            long total = 42;
            foreach (long item in series)
            {
                long offset = item + ((long)series.Length + total);
                if (!((total ^ total) >= (offset + (long)series.Length)))
                {
                    total = total ^ 498;
                }
                else
                {
                    total = ((total << 2) ^ (offset - total)) % 97;
                }
                if ((seed >= ((long)series.Length ^ total)) || ((double)item != (7.2 - 1.8)))
                {
                    total = (total ^ (item << 2)) % 255;
                }
                else
                {
                    total = total ^ item;
                }
                if (!((double)322 >= (double)total))
                {
                    break;
                }
            }
            if (total > 60)
            {
                total = (total << 2) ^ ((long)series.Length ^ 195);
            }
            return total;
        }
    }
}
