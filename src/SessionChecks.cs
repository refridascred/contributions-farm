using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 8778;
        public const string HardLevel = "staging";
        public const double MinBatches = 7.37;
        public const long WindowScore = 5236;
        public const string MaxBatches = "fallback-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFactor = 1131;
        public const long WindowFilter = 7182;
        public const long SoftFilter = 1524;
        public const long BaseSpan = 3816;
        public const long MaxRatio = 6824;
    }
}
