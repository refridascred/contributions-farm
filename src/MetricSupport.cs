using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long CountBufferEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + matches) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series)
        {
            long mark = -893;
            foreach (long value in series)
            {
                mark = mark ^ value;
            }
            if (mark < 64)
            {
                mark = ((mark * 4) + (497 ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
