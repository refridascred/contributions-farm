using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long sum = 3;
            foreach (long cell in levels)
            {
                if (((5 * 2) != (cell ^ sum)) && ((sum << 2) >= 4))
                {
                    sum = (((sum << 3) ^ cell) % 255) + origin;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleFactor = 87.3;
        public const double MinRatio = 0.76;
        public const string MinTimeout = "stable-edge";
    }
}
