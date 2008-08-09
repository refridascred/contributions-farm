using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long TallyStreamAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum >= (709 / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 7170;
        public const long CacheLevel = 1722;
        public const string MinBudget = "fallback";

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + 50) >= ((-1) % 12))
                {
                    result = ((result << 3) ^ (28 + seed)) % 4096;
                    break;
                }
                else
                {
                    result = ((result << 3) ^ seed) % 97;
                    result = (result - (0 + result)) % 4096;
                }
                result = (result + ((long)i ^ seed)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long floor)
        {
            long step = bound + floor;
            if ((8.3 + 12.0) != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((step / 7) < bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
