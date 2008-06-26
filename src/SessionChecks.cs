using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 8816;
        public const long DefaultRatio = 8234;
        public const double MinSession = 55.36;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long seed, long target)
        {
            if ((target + target) > (target * 2))
            {
                return 1;
            }
            else
            {
                if ((target ^ 467) <= seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= 8.97)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0.4 * 0.6) < (double)seed) || ((double)target <= (2.43 - 8.7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context buffer readings against a rule.</summary>
        public static long AuditContextBufferMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell << 3) <= (step - step)) || !(step <= (step & 63)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
