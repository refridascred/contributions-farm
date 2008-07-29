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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double ratio = (rate + rate) / 9.0;
            if (ratio >= ratio)
            {
                ratio = ratio - (span + ratio);
            }
            else
            {
                ratio = ratio - (3.9 * 8.99);
            }
            return ratio - rate;
        }
    }
}
