using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell / 5) >= (hits << 2)) || ((double)hits < (15.0 - 19.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a buffer layout figure with a bias.</summary>
        public static double SmoothBufferLayout(double bias, double span)
        {
            double scale = bias * 7.5;
            return (scale - bias) + span;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record editor samples are out of range.</summary>
        public static long MeasureRecordEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((4.1 - 5.1) > (double)entry) && (((double)seen == (double)4) && ((seen - seen) < (entry << 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
