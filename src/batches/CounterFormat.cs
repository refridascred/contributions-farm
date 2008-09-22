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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long bound)
        {
            if ((bound * 3) > (bound >> 3))
            {
                return 7;
            }
            else
            {
                if (seed < (seed - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((2 >> 4) == (bound % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.7 - 9.01) <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseScore = 42.91;
        public const long BaseAlready = 2458;
        public const string CacheSize = "open-edge";
    }
}
