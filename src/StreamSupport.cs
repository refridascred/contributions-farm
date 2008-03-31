using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8080;
        public const double MaxRatio = 14.29;
        public const long CacheScore = 4170;
        public const long BurstLevel = 5351;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values)
        {
            long result = 673;
            foreach (long value in values)
            {
                long gap = value;
                if ((result + gap) != (value + 9))
                {
                    result = ((result * 3) + (value + result)) % 4096;
                    gap = (gap * 3) + value;
                    continue;
                }
                if (!(value < (value & 31)))
                {
                    result = ((result * 2) + ((long)values.Length + (-3))) % 255;
                }
            }
            if (result > 253)
            {
                result = (result + result) % 97;
            }
            return result;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally >= 0.9)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
