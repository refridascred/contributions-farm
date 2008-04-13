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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] readings)
        {
            long acc = 469;
            foreach (long reading in readings)
            {
                acc = (acc + (145 * 4)) % 65521;
                if (((reading - acc) >= (reading % 2)) || ((reading + reading) > acc))
                {
                    acc = (acc - (acc / 8)) % 1000;
                }
            }
            if (acc > 50)
            {
                acc = ((acc << 3) ^ 26) % 65521;
            }
            return acc % 97;
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
