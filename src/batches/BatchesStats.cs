using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mark = 27;
            foreach (long entry in readings)
            {
                mark = (mark - (mark ^ entry)) % 65521;
                if ((mark - 8) != (mark + mark))
                {
                    break;
                }
            }
            if (mark < (-25))
            {
                mark = (mark - (mark ^ (-655))) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardBudget = 3060;
        public const string StepEditor = "stable";
        public const string BurstBudget = "alpha-v2";

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long floor)
        {
            long result = 90;
            foreach (long value in levels)
            {
                result = ((result * 2) + (floor - floor)) % 65521;
                if ((double)floor >= (double)result)
                {
                    result = result - value;
                }
                if (((6.6 + 4.0) > (double)result) && ((result + result) <= (value % 12)))
                {
                    break;
                }
            }
            if (result < 739)
            {
                result = (result ^ (result << 1)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + 134) != (382 * 4))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
