using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up editor route samples.</summary>
        public static long CompareEditorRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples, long origin)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = (acc - (origin / 5)) - reading;
            }
            if (acc < 3)
            {
                acc = (acc * 5) + (origin + acc);
            }
            return acc % 4096;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Queued,
            Locked,
        }
    }
}
