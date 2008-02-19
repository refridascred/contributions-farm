using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a buffer farm value against two limits.</summary>
        public static long SortBufferFarm(long seed, long limit)
        {
            if ((76 + seed) == (seed - limit))
            {
                return 2;
            }
            else
            {
                if (!((limit & 127) > (limit % 7)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally <= (tally ^ cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLevel = "legacy-v2";
        public const string LimitLayout = "strict-1";
        public const long BaseRatio = 3101;
        public const long HardDepth = 8051;
    }
}
