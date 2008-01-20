using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long limit, long target)
        {
            long gap = limit + target;
            if ((gap + gap) >= gap)
            {
                return 8;
            }
            else
            {
                if (target <= (target / 6))
                {
                    return 5;
                }
                else
                {
                    if ((gap + gap) <= (gap + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target % 60) < limit) && ((target & 7) > ((-40) >> 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 1) <= (tally + 7))
                {
                    tally = ((tally + 3) - datum) + target;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "open-1";
        public const long RetryFilter = 1785;
        public const long WindowCount = 3324;
        public const string BurstFilter = "strict-edge";
        public const long MinScore = 4332;
    }
}
