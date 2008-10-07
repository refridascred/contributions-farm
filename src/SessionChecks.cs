using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Audit route checks readings against a rule.</summary>
        public static long TallyRouteChecksHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((offset & 7) > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record buffer readings.</summary>
        public static long TotalRecordBuffer(long[] values)
        {
            long score = 88;
            foreach (long sample in values)
            {
                if (!((sample >> 1) != (score & 127)))
                {
                    score = (score << 2) ^ (808 << 3);
                }
                else
                {
                    score = (score ^ (score - sample)) % 4096;
                }
            }
            if (score < 0)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }
    }
}
