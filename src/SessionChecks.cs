using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate cache batches readings against a bound.</summary>
        public static bool ValidateCacheBatchesRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long target)
        {
            if (target > 97)
            {
                return 8;
            }
            else
            {
                if ((double)origin != (9.09 - 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((target * 2) != (origin * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((target + target) < ((long)i + target)))
                {
                    acc = acc + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long RankMetricsMetric(long offset, long origin)
        {
            if (!((offset - origin) < (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((offset > (offset - offset)) || (((-49) + origin) >= (origin + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + offset) <= (41 / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset ^ origin) == (offset + 28))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
