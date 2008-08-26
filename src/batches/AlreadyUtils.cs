using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry == (0.89 / 3.0)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
