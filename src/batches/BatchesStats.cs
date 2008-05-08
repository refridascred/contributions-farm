using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long CountBatchChecksMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + 1) == (seen / 3))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Combine tools context values into a single score.</summary>
        public static long TallyToolsContext(long[] values, long bound)
        {
            long state = 38;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ 755) ^ sample;
                if ((2 < (state % 100)) || ((bound >> 3) <= bound))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long ScoreGraphStats(long[] values)
        {
            long total = 486;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (((total ^ (-5)) % 4096) ^ (long)i) - reading;
                }
                if ((5.0 * 0.83) > 9.05)
                {
                    total = (total * 2) + (total << 3);
                }
            }
            return total % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 9149;
        public const long StepWidth = 1091;
        public const long BaseSize = 8222;
        public const long HardBudget = 9028;
    }
}
