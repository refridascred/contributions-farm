using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 1) != (830 * 3)) && ((cell - cell) <= (step << 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 55.93;
        public const string WindowContributi = "open-v2";
        public const double BurstCount = 44.49;
        public const double HardInterval = 43.63;
        public const string BurstContributi = "staging-1";
    }
}
