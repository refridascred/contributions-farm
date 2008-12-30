using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit githubfarm cluster readings against a rule.</summary>
        public static long AuditGithubfarmClusterHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((0 >> 3) < limit)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format schema samples.</summary>
        public static long WeighFormatSchema(long[] levels, long target)
        {
            long anchor = 866;
            foreach (long cell in levels)
            {
                if ((cell <= anchor) || ((cell / 3) > (246 % 10)))
                {
                    anchor = (((anchor * 3) + (anchor - anchor)) % 101) + target;
                }
            }
            return anchor;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
