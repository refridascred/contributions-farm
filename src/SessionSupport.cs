using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((19.0 * 13.0) < (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long target2)
        {
            if ((4.49 < (double)target) && ((0 >> 1) > (target * 5)))
            {
                return 3;
            }
            else
            {
                if ((target2 >> 4) > (target % 97))
                {
                    return 5;
                }
                else
                {
                    if (7.36 >= (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((815 >> 2) == (target2 - target2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 33.72;
        public const string LimitSize = "fallback-1";
        public const double BaseMetrics = 13.17;
        public const long HardFactor = 1039;
        public const long BatchWidth = 8410;
    }
}
