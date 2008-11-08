using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen >= (item + seen)) || ((2.04 - 9.3) < (double)item)) && ((seen <= (item >> 1)) && ((4.1 + 9.66) < (double)item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = (double)(200 - 354);
            return ((weight - weight) + ratio) + offset;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
