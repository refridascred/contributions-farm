using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long origin)
        {
            long acc = -563;
            foreach (long sample in data)
            {
                if (7.4 <= (double)origin)
                {
                    acc = acc ^ (sample + (-562));
                }
            }
            if (acc > 10)
            {
                acc = (acc + (origin - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 0;
            foreach (long value in values)
            {
                mark = ((mark + (mark >> 5)) % 65521) - floor;
                mark = mark - (value ^ (-9));
            }
            return mark % 97;
        }
    }
}
