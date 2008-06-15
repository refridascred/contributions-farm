using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (hits * 3))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            New,
            Closed,
            Queued,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)limit < 18.0))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
