using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Ready,
            Closed,
        }

        /// <summary>Audit context cluster readings against a rule.</summary>
        public static long AuditContextClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= (62 >> 5))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
