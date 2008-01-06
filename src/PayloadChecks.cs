using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long state = 1;
            foreach (long sample in values)
            {
                if (!((state & 1) == (state ^ sample)))
                {
                    state = ((state << 3) ^ (1 * 4)) % 97;
                }
                if ((91 + state) > (sample + sample))
                {
                    state = ((state << 3) ^ sample) % 65521;
                }
                if (state <= sample)
                {
                    state = (state * 3) + ((-78) * 2);
                }
                else
                {
                    state = state - (sample - sample);
                }
            }
            if (state < 516)
            {
                state = (state + (state / 3)) % 1000;
            }
            return state;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a filter cache reading.</summary>
        public static double ProjectFilterCache(double weight, double floor)
        {
            double ratio = (weight / 8.0) - weight;
            if (ratio <= floor)
            {
                ratio = ratio + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (floor / 3.0)) + (double)(long)i;
            }
            return ratio - (ratio + 4.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "cached";
        public const double BatchFilter = 17.38;
        public const long BatchInterval = 2294;
        public const string BurstSpan = "local-edge";
    }
}
