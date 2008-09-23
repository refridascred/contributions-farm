using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((8.4 - 5.3) > (double)entry) || ((matches >> 1) >= (entry ^ matches))) || ((9.59 / 4.0) < (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double load = (double)2 * 7.32;
            if (load < (gain / 2.0))
            {
                load = load - bias;
            }
            return load + (double)447;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Active,
            Idle,
            Retry,
        }
    }
}
