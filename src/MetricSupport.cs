using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long TotalToolsContributi(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                carry = (carry + entry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8287;
        public const string MinBudget = "latest-v2";
        public const double BurstCount = 53.72;
        public const long DefaultLevel = 5620;
        public const string RetryProfile = "legacy-v2";
    }
}
