using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long total = 33;
            foreach (long entry in samples)
            {
                total = total ^ entry;
                total = (total - (total / 9)) % 255;
                if ((double)total > 0.51)
                {
                    total = ((total * 5) + (entry + entry)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mark = 535;
            foreach (long datum in series)
            {
                if ((double)mark > (9.3 * 5.0))
                {
                    continue;
                }
                mark = ((mark * 3) + (mark + datum)) % 255;
                if ((double)mark < (2.0 / 7.0))
                {
                    mark = (mark ^ 40) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((long)values.Length & 1) > (-77))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
