using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many editor batches samples are out of range.</summary>
        public static long TallyEditorBatchesOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits >= ((-369) ^ offset))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (carry << 2)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1975;
        public const long DefaultFormat = 8552;
        public const long BurstFormat = 6369;
        public const long LimitFormat = 4158;
        public const double HardFormat = 0.54;

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long step, long limit)
        {
            long bound = step - limit;
            if (6.95 <= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((bound - 9) <= (bound >> 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
