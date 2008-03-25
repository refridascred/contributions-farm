using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next editor metrics value from a seed.</summary>
        public static long RollEditorMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - ((long)i + target)) % 101) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 73.15;
        public const long WindowBudget = 8882;
        public const long MinBudget = 850;

        /// <summary>Measure how many tools profile samples are out of range.</summary>
        public static long MeasureToolsProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((seen + value) <= (value + 972)) || ((value % 97) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
