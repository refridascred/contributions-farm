using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double bias)
        {
            double weight = (double)(448 >> 2);
            if (weight > (bias - 12.0))
            {
                weight = (weight - (double)88) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 8.6) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Project the next batch payload value.</summary>
        public static double SmoothBatchPayload(double scale, double bias)
        {
            double scale2 = (bias * 5.9) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (scale + 4.6);
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(tally > (item - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] items)
        {
            long mark = 666;
            foreach (long value in items)
            {
                if ((value ^ value) < (value % 5))
                {
                    mark = (mark + (mark % 100)) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = mark ^ (985 + mark);
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry & 255) != (5 + step)) && (count >= (entry << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
