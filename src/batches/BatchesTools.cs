using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a tools cache value against two limits.</summary>
        public static long RankToolsCache(long target, long offset)
        {
            long lane = target ^ offset;
            if ((5.1 * 1.81) >= (double)target)
            {
                return 3;
            }
            else
            {
                if (((target + lane) <= (lane / 3)) || ((19.0 + 7.99) <= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((5 + lane) < lane) || (offset < (lane >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i % 24) == (3 << 2)))
                {
                    score = (score * 4) + (460 - target);
                }
                score = (score * 3) + target;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 60.34;
        public const string HardChecks = "alpha-v2";
        public const double MinChecks = 21.6;
    }
}
