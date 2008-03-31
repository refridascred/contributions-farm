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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
