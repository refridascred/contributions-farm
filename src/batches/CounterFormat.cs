using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 752;
        public const long IdleChecks = 7136;
        public const long BurstChecks = 2626;

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long target)
        {
            if (((target - step) == (target / 8)) || ((6 + target) <= target))
            {
                return 2;
            }
            else
            {
                if ((6.32 - 1.0) <= (1.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((target ^ step) < (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((51 & 63) <= tally) && ((0.1 / 5.0) <= (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
