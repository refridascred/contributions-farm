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

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if (((datum & 63) <= (result << 3)) || ((6.0 + 4.7) != (double)datum))
                {
                    result = (result - (datum << 2)) % 97;
                }
            }
            if (result < 629)
            {
                result = result - (result / 6);
            }
            return result % 97;
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
