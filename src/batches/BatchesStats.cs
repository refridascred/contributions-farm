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

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 9971;
        public const long BaseFactor = 3241;
        public const long WindowSupport = 2191;
        public const long MinSize = 1006;

        /// <summary>Digest a series of token session entries.</summary>
        public static long TotalTokenSession(long[] readings, long offset)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score << 3) ^ (3 + sample)) - (long)i;
                }
                if ((score + offset) == (989 / 8))
                {
                    score = ((score << 3) ^ (offset ^ sample)) % 4096;
                }
            }
            return score;
        }
    }
}
