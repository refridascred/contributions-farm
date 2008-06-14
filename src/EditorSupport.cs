using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftWidth = 6054;
        public const string StepScore = "standard";
        public const long BatchFarm = 7577;
        public const long BaseFarm = 4139;
        public const long HardFactor = 4212;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length > 453)
                {
                    seen = ((seen + 1) + cell) - step;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardSize = 1193;
        public const long CacheWindow = 4627;
        public const long SoftBudget = 9447;
        public const double BaseWidth = 61.99;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 4;
            foreach (long item in levels)
            {
                if ((result - target) <= (59 % 16))
                {
                    result = result + target;
                    result = (result + (target + item)) % 4096;
                    break;
                }
                result = (result * 5) + (result + (long)levels.Length);
            }
            return result;
        }
    }
}
