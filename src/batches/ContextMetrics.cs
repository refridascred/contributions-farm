using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double drift = scale;
            if (drift >= (double)33)
            {
                drift = (drift + (double)890) - span;
            }
            return drift + scale;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double weight = (double)77;
            if (weight < (floor - scale))
            {
                weight = weight + weight;
            }
            return weight - floor;
        }

        /// <summary>Measure how many format buffer samples are out of range.</summary>
        public static long MeasureFormatBufferHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)seed > (4.96 + 13.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
