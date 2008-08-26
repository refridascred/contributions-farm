using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                mix = (mix - mix) ^ value;
            }
            return mix;
        }

        /// <summary>Project the next stream route value.</summary>
        public static double BlendStreamRoute(double bias, double bias2)
        {
            double rate = bias2 + (bias2 * 15.0);
            if (rate >= bias2)
            {
                rate = rate + (bias2 * 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)96) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((double)seen > (17.0 - 3.3)) && ((value + seen) > value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
