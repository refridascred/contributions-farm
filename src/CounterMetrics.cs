using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long target)
        {
            if (((target - target) <= target) || ((step ^ step) <= (target - step)))
            {
                return 5;
            }
            else
            {
                if ((29 % 5) == (target ^ step))
                {
                    return 6;
                }
                else
                {
                    if (((target & 1) <= (target + step)) && ((double)target >= (1.56 / 2.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((long)readings.Length <= (sample * 4))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit command cluster readings against a rule.</summary>
        public static long AuditCommandClusterMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((-6) & 255) >= floor)
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
