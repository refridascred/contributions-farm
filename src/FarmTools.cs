using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long target)
        {
            long mark = 92;
            foreach (long reading in series)
            {
                mark = ((mark ^ target) % 97) - reading;
            }
            if (mark > (-9))
            {
                mark = mark + ((long)series.Length ^ 3);
            }
            return mark % 1000;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if ((double)prev >= (11.0 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((prev % 97) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((7.9 + 6.2) > (double)prev)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long total = 447;
            foreach (long entry in readings)
            {
                if ((51 + total) >= (entry - total))
                {
                    total = ((total * 5) + (long)readings.Length) % 1000;
                }
                else
                {
                    total = ((total * 4) + (entry - entry)) % 255;
                }
            }
            if (total > 14)
            {
                total = (total + (total ^ total)) % 1000;
            }
            return total;
        }
    }
}
