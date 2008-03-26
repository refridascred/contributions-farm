using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ sample) < (7 >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = (score - (origin - (long)i)) % 97;
                long tally = score;
                score = (score * 2) + (tally >> 1);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepSpan = 2801;
        public const double SoftCount = 15.08;
        public const string IdleRatio = "staging";
        public const double MaxWindow = 42.6;
        public const double SoftWidth = 9.5;
    }
}
