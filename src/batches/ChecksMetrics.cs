using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every record notes entry stays within the limit.</summary>
        public static bool CheckRecordNotesLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally % 24) < (datum - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Stale,
            Synced,
            Ready,
        }
    }
}
