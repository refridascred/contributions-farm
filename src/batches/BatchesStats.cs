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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (seed <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
