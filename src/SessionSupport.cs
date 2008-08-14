using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long cell in levels)
            {
                mix = (mix + cell) - origin;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowBudget = 96.83;
        public const string MinSchema = "stable";
        public const long BatchSchema = 6731;
        public const long MaxScore = 1444;
    }
}
