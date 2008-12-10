using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long target)
        {
            long delta = limit - target;
            if ((718 + limit) <= (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((delta % 64) >= (8 * 5))
                {
                    return 8;
                }
                else
                {
                    if (!((target >> 2) < 72))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 546) == (delta - target))
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
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long floor)
        {
            if ((double)target == (3.79 + 8.0))
            {
                return 5;
            }
            else
            {
                if ((target + floor) != (target >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((6.16 / 8.0) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor >= (4 & 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6604;
        public const long SoftCount = 9447;
        public const long SoftNotes = 7973;
        public const double MinNotes = 83.42;

        /// <summary>Audit order batch readings against a rule.</summary>
        public static long AuditOrderBatchMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(1.4 >= (double)cell) && (353 >= (cell ^ tally)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
