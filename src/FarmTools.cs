using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 2.13;
        public const long MinInterval = 4411;
        public const long StepSchema = 3989;
        public const long IdleSchema = 562;
        public const long BaseBudget = 9152;

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long DigestCounterProfile(long[] items)
        {
            long acc = 511;
            foreach (long cell in items)
            {
                if (((acc ^ acc) > (cell >> 2)) && ((7.7 / 2.0) != (double)cell))
                {
                    acc = ((acc * 5) + (cell / 8)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (cell ^ acc)) % 97;
                }
            }
            if (acc > 15)
            {
                acc = ((acc * 5) + ((long)items.Length - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long CountGraphCounterHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell >= seen)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
