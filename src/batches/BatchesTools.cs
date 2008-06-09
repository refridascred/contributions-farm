using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry window samples are out of range.</summary>
        public static long AuditEntryWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen > cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
