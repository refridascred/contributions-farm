using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset - gap) <= (gap * 4))
            {
                return 0;
            }
            else
            {
                if ((offset - gap) > (offset << 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (5.0 - 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (gap > (gap + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 8322;
        public const long BatchBudget = 2341;
        public const long LimitScore = 9689;
        public const double BaseChecks = 14.77;

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long bound)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((((sum << 2) ^ (sum + sum)) % 255) + sample) + bound;
            }
            return sum % 4096;
        }
    }
}
