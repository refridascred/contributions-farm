using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first graph queue entry that matches the target.</summary>
        public static long SeekGraphQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length <= 2.0)
                {
                    hits = ((hits + 3) + item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values, long seed)
        {
            long carry = 61;
            foreach (long cell in values)
            {
                carry = ((carry << 3) ^ (long)values.Length) + seed;
                carry = ((carry << 3) ^ (cell + cell)) % 65521;
            }
            return carry;
        }
    }
}
