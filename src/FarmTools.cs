using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Retry,
            Closed,
            New,
            Pending,
        }

        /// <summary>Compare every pair of cache entry readings.</summary>
        public static long CompareCacheEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + value) <= (seen ^ 847)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
