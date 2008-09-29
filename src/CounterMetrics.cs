using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi filter reading.</summary>
        public static double ProjectContributiFilter(double scale, double span)
        {
            double ratio = span - (15.0 - span);
            if (ratio >= (ratio + scale))
            {
                ratio = ratio - (double)18;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels, long step)
        {
            long result = 443;
            foreach (long sample in levels)
            {
                if ((double)sample != (double)result)
                {
                    result = ((result - (result + result)) % 4096) - step;
                }
            }
            if (result < 892)
            {
                result = (result ^ (95 >> 5)) % 4096;
            }
            return result;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double mean = (weight / 8.0) * 19.0;
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean + weight);
            }
            return mean - 1.06;
        }
    }
}
