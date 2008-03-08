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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
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
