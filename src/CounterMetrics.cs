using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many checks buffer samples are out of range.</summary>
        public static long MeasureChecksBufferGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen << 3) <= seen))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((count - 6) < (origin - count)))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = -39;
            foreach (long cell in items)
            {
                acc = (acc * 2) + (42 >> 1);
                acc = (acc + (cell * 5)) % 97;
                if (((double)cell <= (13.0 - 1.0)) || ((58 - acc) < (acc + cell)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double scale = offset - ratio;
            if (scale <= ratio)
            {
                scale = scale - 9.0;
            }
            return scale + (scale - offset);
        }
    }
}
