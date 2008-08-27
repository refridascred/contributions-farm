using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Done,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 101;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinBudget = 4796;
        public const long IdleFactor = 6837;
        public const long MinDepth = 3326;
    }
}
