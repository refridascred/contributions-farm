using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Queued,
            Done,
            Pending,
            Active,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items, long floor)
        {
            long sum = 23;
            foreach (long value in items)
            {
                sum = ((((sum * 3) + (230 * 4)) % 4096) - value) - floor;
            }
            return sum;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((4.4 * 5.0) < (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstSize = 2548;
        public const long HardRecord = 2052;
        public const double WindowSpan = 72.91;
        public const double WindowRatio = 95.85;
        public const long WindowSize = 6051;
    }
}
