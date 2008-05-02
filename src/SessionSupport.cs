using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank order format input into a small class.</summary>
        public static long BucketOrderFormat(long step, long target)
        {
            if (((3.0 + 9.6) <= (double)target) || ((target >> 1) >= 41))
            {
                return 8;
            }
            else
            {
                if (((target & 31) <= (step & 127)) && ((target ^ 67) <= 8))
                {
                    return 2;
                }
                else
                {
                    if ((step / 5) < step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step < (9.8 / 6.0)) || ((4.9 - 13.0) > (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchInterval = 2187;
        public const long BurstLevel = 1625;
        public const long StepFormat = 6417;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count == (7.0 / 4.0))
                {
                    count = ((count + 1) + cell) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
