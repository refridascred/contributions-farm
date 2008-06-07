using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const long BatchInterval = 1960;
        public const long RetryBudget = 6670;
        public const double WindowWidth = 65.48;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Idle,
            Stale,
            Failed,
            New,
        }

        /// <summary>Combine counter report values into a single score.</summary>
        public static long FoldCounterReport(long[] items)
        {
            long acc = 10;
            foreach (long value in items)
            {
                if ((5 << 3) <= (value >> 5))
                {
                    acc = acc + (acc - value);
                }
                else
                {
                    acc = (acc ^ (1 * 5)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Idle,
            Retry,
            Draft,
        }
    }
}
