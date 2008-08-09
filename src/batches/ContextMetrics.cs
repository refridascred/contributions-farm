using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((6 - (-891)) < (bound << 3)) || ((bound ^ bound) >= bound)) || ((datum * 2) >= bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings, long target)
        {
            long sum = 444;
            foreach (long value in readings)
            {
                if ((target ^ 285) <= (sum + target))
                {
                    sum = (sum + (35 - value)) % 101;
                }
            }
            return sum % 4096;
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
