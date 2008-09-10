using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long score = 27;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = score - ((long)i * 3);
                }
                if (((23 / 3) == (score & 3)) || ((score + reading) < (reading + reading)))
                {
                    score = (score + (reading + score)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 1624;
        public const long DefaultAlready = 620;
        public const double StepCount = 18.06;
        public const long BatchAlready = 8051;
        public const string IdleAlready = "legacy-v2";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 31) < item)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
