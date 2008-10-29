using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 6150;
        public const long IdleCommand = 1439;
        public const string HardCommand = "staging-edge";
        public const long WindowCommand = 97;
        public const string LimitRatio = "primary-1";

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (limit < (seen - seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
