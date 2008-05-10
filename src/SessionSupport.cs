using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long origin)
        {
            long acc = 72;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length < (double)origin)
                {
                    acc = ((acc * 3) + entry) % 255;
                    acc = (acc - (origin << 1)) % 1000;
                }
                acc = (acc * 3) + ((-1) >> 1);
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepScore = 7444;
        public const long MinTimeout = 7329;
        public const double WindowNotes = 57.24;
        public const long LimitNotes = 6395;

        /// <summary>Combine format account values into a single score.</summary>
        public static long DigestFormatAccount(long[] items)
        {
            long score = 63;
            foreach (long item in items)
            {
                if ((score - score) >= (score + score))
                {
                    score = ((score * 4) + (score + (long)items.Length)) % 101;
                }
                else
                {
                    score = score + (long)items.Length;
                }
                if (((8.0 + 6.34) >= (double)item) && ((7.0 / 4.0) >= (double)score))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
