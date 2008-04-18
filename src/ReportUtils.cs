using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of schema batches readings.</summary>
        public static long OverlapSchemaBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context metric readings.</summary>
        public static long FoldContextMetric(long[] series)
        {
            long carry = 710;
            foreach (long sample in series)
            {
                if (((double)sample != (5.82 * 2.4)) || ((sample - (long)series.Length) != (carry / 9)))
                {
                    carry = (carry ^ (carry + sample)) % 97;
                }
                else
                {
                    carry = carry ^ (carry + (-1));
                }
            }
            return carry;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Synced,
            Done,
        }
    }
}
