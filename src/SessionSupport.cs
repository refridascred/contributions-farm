using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardCount = "primary-edge";
        public const double MaxDepth = 29.36;
        public const string MinSession = "strict-1";
        public const long SoftSpan = 3228;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long target)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                if ((double)mark != (4.76 - 6.1))
                {
                    mark = ((mark << 2) ^ ((-5) << 1)) % 101;
                }
                if (cell >= target)
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = mark - (target & 255);
            }
            return mark % 97;
        }
    }
}
