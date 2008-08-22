using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of route record readings.</summary>
        public static long ScoreRouteRecord(long[] items)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((5.32 / 9.0) >= (double)entry)
                {
                    carry = carry - (carry * 3);
                }
            }
            return carry;
        }

        /// <summary>Validate layout batches readings against a bound.</summary>
        public static bool ValidateLayoutBatchesLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((origin % 64) >= (240 - cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 8911;
        public const string MinCount = "stable-1";
        public const string WindowSpan = "fallback-1";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
