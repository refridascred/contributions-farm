using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long offset, long bound)
        {
            if ((bound - offset) >= bound)
            {
                return 3;
            }
            else
            {
                if ((offset + bound) <= 71)
                {
                    return 2;
                }
                else
                {
                    if (!((bound >> 2) >= (bound & 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a order command reading.</summary>
        public static double AdjustOrderCommand(double weight, double offset)
        {
            double bias = offset;
            if (bias >= bias)
            {
                bias = bias + (weight + 6.0);
            }
            else
            {
                bias = bias - (weight - 6.3);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias + (double)498;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((floor ^ (-477)) <= (seen ^ entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < (cell + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
