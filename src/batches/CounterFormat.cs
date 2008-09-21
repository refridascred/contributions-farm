using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ value) >= (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long origin2)
        {
            long offset = origin - origin2;
            if (!((origin + origin) != (offset << 1)))
            {
                return 7;
            }
            else
            {
                if (((origin / 3) <= offset) || (origin > (origin << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 8) == (origin ^ 509))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 2) <= (offset & 15))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 9267;
        public const string MinTimeout = "primary-v2";
        public const long IdleCommand = 395;
    }
}
