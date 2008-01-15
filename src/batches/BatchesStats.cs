using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits <= (2.26 / 3.0))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long floor)
        {
            long anchor = 890;
            foreach (long reading in readings)
            {
                if (((reading & 7) != (811 & 63)) || ((reading + 45) >= ((long)readings.Length % 16)))
                {
                    anchor = (anchor * 2) + (anchor - anchor);
                }
                else
                {
                    anchor = anchor + (reading - floor);
                }
            }
            if (anchor > 653)
            {
                anchor = ((anchor * 5) + (floor + anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
