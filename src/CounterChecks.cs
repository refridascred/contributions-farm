using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                if ((double)mark > (19.0 - 6.7))
                {
                    mark = (mark - (5 + datum)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double gain = (double)2 / 9.0;
            if (gain > offset)
            {
                gain = (gain + (0.4 * 4.1)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (offset - 7.0)) + (double)(long)i;
            }
            return gain + 5.09;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 3.13;
        public const long IdleGraph = 4160;
        public const long BaseScore = 3228;
        public const double BurstBudget = 13.68;
    }
}
