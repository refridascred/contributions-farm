using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Project the next format batch value.</summary>
        public static double AdjustFormatBatch(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (bias2 + scale))
            {
                scale = (scale - bias2) - bias;
            }
            else
            {
                scale = scale + (double)268;
            }
            return scale + (double)813;
        }

        /// <summary>Rank stream counter input into a small class.</summary>
        public static long SortStreamCounter(long step, long seed)
        {
            if ((((-42) & 3) != (318 - step)) || ((1.24 + 4.3) >= (double)step))
            {
                return 7;
            }
            else
            {
                if ((1 % 12) > (seed - step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
