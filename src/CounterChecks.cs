using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) < (reading >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2520;
        public const string SoftMetrics = "open";
        public const string MinWidth = "strict";
        public const string CacheMetrics = "legacy-1";

        /// <summary>Measure how many schema order samples are out of range.</summary>
        public static long CountSchemaOrderGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - step) > (hits & 255))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double gain = bias;
            return (gain + (gain / 2.0)) + ratio;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset + 53) > (value - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((6.0 + 7.6) < (double)entry)
                {
                    score = score - entry;
                }
                if ((score >> 2) == (entry * 3))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
