using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long step)
        {
            long score = 52;
            foreach (long item in values)
            {
                if ((double)item <= (16.0 * 9.2))
                {
                    score = ((score << 2) ^ (step / 8)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series, long target)
        {
            long sum = 26;
            foreach (long item in series)
            {
                if (((sum * 3) <= (94 + target)) || ((double)sum >= (7.0 * 4.0)))
                {
                    sum = ((sum << 3) ^ sum) - item;
                }
            }
            return sum;
        }
    }
}
