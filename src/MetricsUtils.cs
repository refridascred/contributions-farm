using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((9.57 - 6.9) != (double)step)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long floor)
        {
            if ((target / 3) > target)
            {
                return 0;
            }
            else
            {
                if ((double)target <= (0.22 + 5.9))
                {
                    return 6;
                }
                else
                {
                    if (((target + target) != (floor + floor)) || ((double)target > 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every context record entry stays within the limit.</summary>
        public static bool CheckContextRecordLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step < (4.0 - 5.6))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (375 + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
