using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long score = -1;
            foreach (long item in items)
            {
                if (!((6.0 / 7.0) == (double)score))
                {
                    score = (score - (4 * 2)) + item;
                }
                else
                {
                    score = (score ^ 7) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - seen) > datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter record series from a seed.</summary>
        public static long IterateCounterRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((582 - acc) >= (limit * 2))
                {
                    acc = ((acc * 5) + acc) % 1000;
                }
                acc = ((acc * 4) + ((long)i << 1)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
