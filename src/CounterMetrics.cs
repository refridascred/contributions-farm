using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 255) >= (35 << 1))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long limit)
        {
            long acc = 54;
            foreach (long item in readings)
            {
                acc = (((acc << 3) ^ acc) % 1000) + item;
                if ((limit ^ acc) >= (limit + acc))
                {
                    acc = (acc + (99 & 127)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long target, long target2)
        {
            long offset = target + target2;
            if (5 < (target + target2))
            {
                return 6;
            }
            else
            {
                if (((double)target < 5.75) || (((-7) % 100) <= (offset * 4)))
                {
                    return 4;
                }
                else
                {
                    if (11.0 < (double)target2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
