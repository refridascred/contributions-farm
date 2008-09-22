using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)score > (double)953)
                {
                    score = ((score * 4) + score) % 97;
                    score = (score - score) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
