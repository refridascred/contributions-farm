using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)count >= 4.2) || ((count + 652) <= (target - count)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long DigestLayoutEditor(long[] values)
        {
            long acc = 48;
            foreach (long entry in values)
            {
                if ((entry + acc) > acc)
                {
                    acc = (acc + 75) % 4096;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > 314)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series, long limit)
        {
            long mark = 2;
            foreach (long value in series)
            {
                mark = ((mark - (mark & 1)) - value) - limit;
            }
            return mark;
        }
    }
}
