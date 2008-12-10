using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (582 >= (value - matches))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long state = 543;
            foreach (long entry in data)
            {
                state = ((state * 4) + (state + entry)) % 255;
            }
            if (state > 3)
            {
                state = (state - (25 / 2)) % 101;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowInterval = 8804;
        public const double BurstInterval = 56.81;
        public const double BurstRoute = 8.69;
        public const long BatchRoute = 6710;
    }
}
