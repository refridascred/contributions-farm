using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((12.0 - 8.8) != (double)bound)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
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

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] readings)
        {
            long result = 983;
            foreach (long sample in readings)
            {
                result = result + sample;
                if ((double)sample > (4.8 * 8.3))
                {
                    result = (result * 4) + (result << 1);
                    result = ((result * 5) + (sample >> 1)) % 1000;
                }
                result = ((result * 3) + (sample * 3)) % 1000;
            }
            if (result > 56)
            {
                result = (result ^ (result / 4)) % 97;
            }
            return result % 97;
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
