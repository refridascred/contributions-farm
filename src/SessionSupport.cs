using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long bound)
        {
            long sum = 6;
            foreach (long value in values)
            {
                if (((sum + bound) >= sum) && ((double)sum <= (double)bound))
                {
                    sum = (sum ^ (bound << 3)) % 4096;
                }
                else
                {
                    sum = (sum * 3) + (value + bound);
                }
            }
            return sum % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = sum - 87;
                if ((7.64 / 5.0) <= (double)cell)
                {
                    sum = sum + (cell * 2);
                }
                if ((cell + sum) < (813 * 5))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
