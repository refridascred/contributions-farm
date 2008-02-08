using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long acc = 411;
            foreach (long sample in readings)
            {
                acc = (((acc ^ acc) % 97) ^ sample) - bound;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long offset)
        {
            if ((step << 3) == (step / 5))
            {
                return 5;
            }
            else
            {
                if ((-870) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset & 31) < (step - step)) || ((step / 6) != (offset - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryScore = 64.68;
        public const long BatchPayload = 7535;
        public const long SoftWidth = 8122;

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
