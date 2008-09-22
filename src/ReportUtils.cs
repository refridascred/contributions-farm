using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Failed,
            Ready,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context record entries.</summary>
        public static long TotalContextRecord(long[] samples, long target)
        {
            long state = 82;
            foreach (long item in samples)
            {
                if ((482 + target) > state)
                {
                    state = (((state * 2) + 44) % 1000) + item;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 8970;
        public const double RetryTimeout = 64.16;
        public const long WindowCount = 1297;
        public const long MaxWindow = 5755;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Retry,
            Draft,
            Closed,
        }
    }
}
