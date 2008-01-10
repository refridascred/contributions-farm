using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data)
        {
            long state = 0;
            foreach (long cell in data)
            {
                if ((264 + 5) > (cell & 15))
                {
                    state = state + (state * 3);
                }
            }
            return state;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Draft,
            Active,
            New,
            Done,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
