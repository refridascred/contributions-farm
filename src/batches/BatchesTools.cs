using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - limit) < (limit % 16))
                {
                    anchor = ((anchor << 2) ^ (limit + limit)) % 255;
                }
                anchor = (anchor - (long)i) % 4096;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
