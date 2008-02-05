using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long acc = 47;
            foreach (long entry in readings)
            {
                if ((entry ^ (-76)) > (entry / 6))
                {
                    acc = (acc + (entry << 1)) % 97;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
                if ((double)acc < (5.0 - 6.2))
                {
                    break;
                }
            }
            if (acc < 48)
            {
                acc = (acc - (88 / 8)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values, long target)
        {
            long mix = 116;
            foreach (long datum in values)
            {
                if ((double)datum > (9.43 + 8.3))
                {
                    mix = ((mix + (datum & 7)) % 65521) - target;
                }
            }
            return mix;
        }

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long MeasureOrderCommandHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (1.64 <= (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
