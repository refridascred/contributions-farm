using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entry entries.</summary>
        public static long ScoreEditorEntry(long[] readings, long seed)
        {
            long anchor = 936;
            foreach (long cell in readings)
            {
                anchor = ((anchor + ((-34) + anchor)) % 1000) + cell;
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ seed) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + seed) >= (hits & 127))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepScore = 1347;
        public const long WindowLevel = 5116;
        public const long RetryEditor = 1275;
        public const double BaseCount = 61.61;
        public const string WindowEditor = "stable-v2";
    }
}
