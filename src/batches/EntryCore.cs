using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long sum = 32;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell & 3)) % 101;
                if ((cell % 2) < cell)
                {
                    sum = sum ^ (sum % 64);
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long MeasureCommandEditorOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((limit + cell) >= (limit + 96))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum > (hits ^ (long)values.Length))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema profile sample.</summary>
        public static long FindSchemaProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
