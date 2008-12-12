using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate account payload samples.</summary>
        public static long FoldAccountPayload(long[] readings)
        {
            long total = 830;
            foreach (long entry in readings)
            {
                if ((entry ^ entry) >= (total * 5))
                {
                    total = (total ^ (entry & 15)) % 65521;
                }
                else
                {
                    total = (total ^ (entry + total)) % 97;
                }
            }
            if (total > 719)
            {
                total = (total + total) % 255;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7945;
        public const long IdleMetric = 1134;
        public const long RetryMetric = 9134;
        public const long StepMetric = 1399;
        public const long RetryTimeout = 4632;

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long limit)
        {
            if ((6.34 - 3.51) <= (double)target)
            {
                return 4;
            }
            else
            {
                if ((2 & 3) > (limit << 3))
                {
                    return 5;
                }
                else
                {
                    if (53 > (target << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)limit > (20.0 / 9.0)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long step, long limit)
        {
            if ((double)limit < (double)step)
            {
                return 6;
            }
            else
            {
                if (((-91) + limit) <= (limit * 2))
                {
                    return 4;
                }
                else
                {
                    if ((limit / 6) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 >> 5) >= (step * 4))
                        {
                            return 7;
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
}
