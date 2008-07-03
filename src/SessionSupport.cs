using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double ratio = 0.51 + (span + 8.5);
            if (ratio >= (double)6)
            {
                ratio = ratio - (ratio - 3.89);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (span - span)) - (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Synced,
            Retry,
            Active,
        }
    }
}
