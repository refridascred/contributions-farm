using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 7651;
        public const long MaxDepth = 5882;
        public const long RetryInterval = 2641;
        public const long MaxSession = 2539;
        public const long DefaultSpan = 580;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long sum = 39;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)seed)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum + seed)) % 97;
                }
            }
            return sum;
        }
    }
}
