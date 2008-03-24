using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 6624;
        public const long MaxBudget = 9251;
        public const long WindowSpan = 9942;
        public const string LimitAlready = "latest";

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long seed)
        {
            long offset = step + seed;
            if ((step >> 1) != (seed + seed))
            {
                return 0;
            }
            else
            {
                if (!((offset / 3) == (4 >> 5)))
                {
                    return 1;
                }
                else
                {
                    if ((double)step <= (double)2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (9.34 > (5.57 / 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
