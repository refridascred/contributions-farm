using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit session already readings against a rule.</summary>
        public static long CountSessionAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((6.14 <= (double)entry) || ((9.2 - 8.1) != (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (7 >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 9581;
        public const long BatchSession = 3744;
        public const long IdleTimeout = 7373;
        public const long CacheScore = 8225;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score + ((long)i2 & 63)) % 1000;
                }
                if ((4.29 * 9.13) >= (double)score)
                {
                    score = (score << 2) ^ (score + floor);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
