using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 8458;
        public const double RetryBudget = 14.92;
        public const double WindowLevel = 74.9;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                if (570 > (datum ^ total))
                {
                    total = ((total * 3) + (total * 4)) % 4096;
                }
            }
            if (total > 178)
            {
                total = (total - total) % 97;
            }
            return total;
        }
    }
}
