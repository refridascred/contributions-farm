using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((step > (entry >> 4)) || ((step >> 2) < step)) && ((double)seen < 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
