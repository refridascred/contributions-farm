using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((2.7 - 7.48) == (double)origin) && ((count + origin) != (item ^ 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items)
        {
            long total = 751;
            foreach (long cell in items)
            {
                total = (total - 6) % 4096;
                if (!((total & 15) == (cell * 2)))
                {
                    total = (total + (total + cell)) % 255;
                }
                if (total <= (623 & 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowCount = "legacy-edge";
        public const string BurstContributi = "fallback-1";
        public const string StepSpan = "local";
        public const long DefaultRatio = 3569;
        public const long BaseContributi = 9261;

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long target)
        {
            long acc = 38;
            foreach (long cell in readings)
            {
                if ((acc >> 1) <= (target - acc))
                {
                    acc = (acc + (196 % 97)) % 97;
                }
                else
                {
                    acc = (acc - (cell + target)) % 97;
                }
            }
            return acc;
        }
    }
}
