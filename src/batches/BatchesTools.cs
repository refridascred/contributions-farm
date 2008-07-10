using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!!((value + seen) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (85 <= (datum + count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long mix = -388;
            foreach (long value in values)
            {
                if (((double)5 != (double)value) && (8.36 < (2.28 * 9.6)))
                {
                    mix = (mix * 3) + (value ^ mix);
                }
                if ((value << 2) >= (0 + value))
                {
                    break;
                }
            }
            if (mix > 2)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }
    }
}
