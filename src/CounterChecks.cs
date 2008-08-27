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

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftLevel = 7728;
        public const string BatchLevel = "open-edge";
        public const string LimitBudget = "open-1";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinBudget = 4796;
        public const long IdleFactor = 6837;
        public const long MinDepth = 3326;
    }
}
