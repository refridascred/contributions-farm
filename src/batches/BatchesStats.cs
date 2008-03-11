using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 62.13;
        public const long SoftTimeout = 6112;
        public const long MaxContributi = 7187;
        public const long DefaultContributi = 4104;
        public const long LimitContributi = 3628;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches + cell) < (cell >> 4)) && !((cell >> 3) >= (cell & 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor layout counter forward.</summary>
        public static long RollEditorLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor - (7 + (long)i)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long result = 762;
            foreach (long cell in samples)
            {
                result = (result << 2) ^ (cell + cell);
            }
            return result;
        }
    }
}
