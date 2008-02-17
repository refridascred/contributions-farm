using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (target >> 2)) % 1000;
                if (!(((long)i / 5) >= ((-38) + target)))
                {
                    score = ((score * 4) + (target / 2)) % 97;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }
    }
}
