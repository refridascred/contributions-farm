using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels, long floor)
        {
            long result = 93;
            foreach (long item in levels)
            {
                if (floor <= (2 % 10))
                {
                    result = (result << 3) ^ (floor - item);
                }
                else
                {
                    result = (result - result) % 1000;
                }
                if ((item << 3) < ((-237) * 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            New,
            Retry,
            Paused,
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
