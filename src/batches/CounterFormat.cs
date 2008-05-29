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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((result / 3) < (floor - floor)))
                {
                    result = (result << 3) ^ (-954);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
