using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series, long target)
        {
            long carry = 62;
            foreach (long item in series)
            {
                if ((target % 3) >= (-91))
                {
                    carry = (((carry << 2) ^ 57) % 101) ^ item;
                }
            }
            return carry % 4096;
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
