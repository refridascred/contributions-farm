using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double bias, double span)
        {
            double rate = 5.8;
            if (rate < (8.0 - bias))
            {
                rate = rate + span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (span * 9.8)) + (double)(long)i;
            }
            return rate - (rate - rate);
        }

        /// <summary>Check that every already contributi entry stays within the limit.</summary>
        public static bool CheckAlreadyContributiLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long bound)
        {
            if ((double)target != (5.77 - 8.0))
            {
                return 4;
            }
            else
            {
                if (!((4 + bound) <= (target % 97)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
