using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading + (-85)) > (0 >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 2359;
        public const long LimitMetrics = 2056;
        public const long BaseScore = 538;
        public const long IdleMetrics = 7038;

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if ((entry % 60) != (carry & 7))
                {
                    carry = (carry * 2) + (carry ^ entry);
                }
                else
                {
                    carry = (carry - ((long)levels.Length + 32)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 87.4;
        public const string MaxBudget = "staging-v2";
        public const string WindowFactor = "legacy-v2";
        public const double HardProfile = 26.77;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values, long bound)
        {
            long acc = 695;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (bound ^ cell)) ^ (long)i;
                }
                acc = (acc * 3) + (acc + cell);
            }
            return acc % 1000;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Closed,
            Done,
        }
    }
}
