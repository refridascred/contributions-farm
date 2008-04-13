using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ cell) % 255;
                acc = acc + (8 + offset);
                acc = acc - (acc ^ offset);
            }
            return acc % 97;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double scale2 = (double)(30 % 3);
            if (scale2 >= (double)19)
            {
                scale2 = (scale2 - (double)6) + span;
            }
            else
            {
                scale2 = scale2 - 1.8;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (scale * 5.5)) - (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length + (long)series.Length) == (item % 10)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate batch cluster samples.</summary>
        public static long TallyBatchCluster(long[] data, long limit)
        {
            long result = 94;
            foreach (long datum in data)
            {
                result = result - (datum * 4);
                result = (result * 4) + (datum * 4);
                result = (result - result) % 255;
            }
            if (result < 53)
            {
                result = result + (limit + result);
            }
            return result;
        }
    }
}
