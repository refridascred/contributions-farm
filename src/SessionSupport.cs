using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long floor)
        {
            if ((floor << 1) == (floor + limit))
            {
                return 3;
            }
            else
            {
                if ((floor < (floor + floor)) || ((0 * 4) == (54 ^ floor)))
                {
                    return 4;
                }
                else
                {
                    if ((limit - 4) == (limit + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + limit) >= (8 >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (count + bound))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long TallyContributiChannelGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count << 2) >= floor)
                {
                    count = (count + 3) - entry;
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
