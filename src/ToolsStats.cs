using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long seed)
        {
            long total = -6;
            foreach (long value in levels)
            {
                total = total ^ value;
            }
            if (total > 6)
            {
                total = total ^ (seed % 12);
            }
            return total;
        }

        /// <summary>Project the next layout window value.</summary>
        public static double ScaleLayoutWindow(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (load - floor))
            {
                load = load - (ratio * 5.9);
            }
            return load - (ratio + floor);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                long edge = score ^ (score % 5);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score + 8) ^ (long)i2;
                    score = (score + (limit ^ edge)) % 101;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values, long seed)
        {
            long mix = -8;
            foreach (long sample in values)
            {
                if ((68 % 10) < (mix * 5))
                {
                    mix = mix ^ (sample + seed);
                }
                if ((double)sample <= 6.5)
                {
                    break;
                }
            }
            if (mix < (-73))
            {
                mix = (mix * 5) + (mix ^ seed);
            }
            return mix;
        }

        /// <summary>Combine metrics batch values into a single score.</summary>
        public static long FoldMetricsBatch(long[] levels, long offset)
        {
            long score = 3;
            foreach (long datum in levels)
            {
                score = score + (datum + offset);
                score = score ^ datum;
            }
            if (score > 981)
            {
                score = ((score * 4) + offset) % 1000;
            }
            return score % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7220;
        public const long DefaultOrder = 6640;
        public const long MinScore = 7119;
    }
}
