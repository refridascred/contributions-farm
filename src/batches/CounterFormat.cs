using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long floor)
        {
            if ((offset >> 4) >= offset)
            {
                return 8;
            }
            else
            {
                if ((floor >> 5) <= (offset >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= (18.0 + 1.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor / 2) == (offset * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
