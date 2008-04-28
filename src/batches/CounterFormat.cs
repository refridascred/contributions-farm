using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue session values into a single score.</summary>
        public static long DigestQueueSession(long[] readings, long offset)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((1.9 + 7.0) != (double)cell)
                {
                    mix = ((mix << 3) ^ (offset - offset)) % 65521;
                }
            }
            if (mix > 18)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) < (11 + 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
