using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((19.0 / 6.0) != (double)acc)
                {
                    acc = ((acc << 3) ^ ((long)i * 4)) % 255;
                    acc = ((acc * 2) + (long)i) % 97;
                }
                if ((59 + seed) <= (268 << 2))
                {
                    acc = (acc << 3) ^ seed;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 25.13;
        public const double SoftWidth = 22.72;
        public const string StepLayout = "standard-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (2.47 - 0.37))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer cache readings.</summary>
        public static long ScoreBufferCache(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if (entry >= (entry + 34))
                {
                    carry = ((carry * 3) + (entry * 5)) % 1000;
                }
            }
            return carry % 97;
        }
    }
}
