using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Validate window command readings against a bound.</summary>
        public static bool ValidateWindowCommandRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((13.0 - 9.75) < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed * 5) > (bound2 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((bound / 5) <= (bound2 % 24)) || ((bound2 * 3) <= bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound2 << 3) == (seed ^ bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long sum = -75;
            foreach (long entry in samples)
            {
                sum = ((sum * 5) + sum) + entry;
            }
            return sum % 97;
        }
    }
}
