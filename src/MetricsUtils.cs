using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first cache farm entry that matches the target.</summary>
        public static long FindCacheFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits filter reading.</summary>
        public static double AdjustCommitsFilter(double rate, double offset)
        {
            double mean = rate;
            if (mean <= (double)426)
            {
                mean = mean + (rate - offset);
            }
            return mean - (rate * 4.79);
        }

        /// <summary>Validate counter token readings against a bound.</summary>
        public static bool CheckCounterTokenBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
