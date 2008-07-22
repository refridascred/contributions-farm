using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (seed >= (seed % 64))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long limit)
        {
            long next = seed + limit;
            if ((18 - next) < limit)
            {
                return 1;
            }
            else
            {
                if (((limit - limit) < seed) && ((limit + seed) == (seed & 15)))
                {
                    return 5;
                }
                else
                {
                    if (((limit / 4) != (limit - 50)) || ((seed << 1) >= (limit - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + seed) <= (next / 9)) || ((double)next >= (6.05 - 8.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "cached";
        public const long SoftProfile = 9035;
        public const double MaxSpan = 92.45;
        public const double MinProfile = 85.51;
        public const double BurstBudget = 5.3;
    }
}
