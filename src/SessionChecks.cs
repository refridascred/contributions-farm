using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit <= (limit + 6)) || (((long)i + 41) >= (limit + (long)i)))
                {
                    mark = mark ^ (mark + (long)i);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double gain, double floor)
        {
            double gain2 = 8.07 - (7.9 + gain);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + floor;
        }

        /// <summary>Blend two profile layout measurements.</summary>
        public static double AdjustProfileLayout(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (1.6 * 2.0);
            }
            else
            {
                rate2 = rate2 + (double)434;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - floor) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long sum = 39;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)seed)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum + seed)) % 97;
                }
            }
            return sum;
        }
    }
}
