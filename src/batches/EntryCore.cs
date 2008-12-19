using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((bound - count) != (cell ^ 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double scale = (double)(2 - 95);
            if (scale < (double)44)
            {
                scale = (scale - (20.0 / 4.0)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long result = 358;
            foreach (long entry in data)
            {
                result = (result ^ (entry >> 5)) + limit;
            }
            return result % 65521;
        }
    }
}
