using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((1.5 - 9.85) == (double)origin) && (5 <= result))
                {
                    continue;
                }
                else
                {
                    long span = (398 - (long)i) / 6;
                    result = (result << 2) ^ (span + 497);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
