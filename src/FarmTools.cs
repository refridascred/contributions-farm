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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + tally) < (item % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
