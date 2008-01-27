using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values)
        {
            long mix = 831;
            foreach (long entry in values)
            {
                mix = (mix + (entry & 1)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = ((mark - 8) % 1000) - item;
            }
            if (mark > 74)
            {
                mark = ((mark * 5) + 33) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Validate cluster filter readings against a bound.</summary>
        public static bool VerifyClusterFilterRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((matches - entry) > (0 + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
