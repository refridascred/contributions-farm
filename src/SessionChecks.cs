using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinBudget = 6669;
        public const long BatchScore = 4631;
        public const long StepAccount = 3432;
        public const long BurstLevel = 9940;
        public const string WindowBudget = "stable";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool VerifyLayoutReportRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series, long limit)
        {
            long carry = 600;
            foreach (long entry in series)
            {
                if (!((carry * 5) <= (limit + limit)))
                {
                    carry = ((carry << 2) ^ (597 + carry)) % 101;
                }
                carry = ((carry * 3) + carry) % 101;
                carry = (carry ^ (limit >> 5)) % 1000;
                if (((double)entry >= (double)241) || ((limit - 8) < (entry & 31)))
                {
                    break;
                }
            }
            if (carry < 12)
            {
                carry = (carry - (limit << 2)) % 1000;
            }
            return carry;
        }
    }
}
