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

        /// <summary>Count command token pairs that satisfy a relation.</summary>
        public static long CompareCommandTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
