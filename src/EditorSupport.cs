using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTimeout = 5396;
        public const long StepRatio = 3841;
        public const long BatchScore = 4615;
        public const long BatchTools = 5714;
        public const double StepTools = 21.41;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)58)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleTimeout = "cached-v2";
        public const long StepMetrics = 9197;
        public const double StepScore = 55.39;
        public const string RetryRatio = "legacy-edge";
        public const string LimitMetrics = "primary-edge";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (target < (52 >> 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long carry = -65;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry + (value - (long)i)) % 65521;
                }
                if ((carry << 1) > (value - carry))
                {
                    carry = carry ^ ((-12) + carry);
                }
            }
            if (carry > 173)
            {
                carry = (carry * 3) + origin;
            }
            return carry;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
