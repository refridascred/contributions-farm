using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (count & 3))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long carry = 859;
            foreach (long value in data)
            {
                if ((carry / 2) != (value + carry))
                {
                    carry = (carry + value) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 1708;
        public const double StepFormat = 52.39;
        public const long HardLevel = 9515;
        public const long HardInterval = 4765;
    }
}
