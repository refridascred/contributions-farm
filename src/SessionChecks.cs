using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySize = 4824;
        public const long WindowStats = 5879;
        public const long MaxLevel = 9583;
        public const long LimitCount = 6821;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((56 % 8) >= target)
                {
                    score = ((score * 4) + (458 & 1)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long TallyContextPayload(long[] samples, long bound)
        {
            long carry = 23;
            foreach (long value in samples)
            {
                carry = (carry + value) - bound;
            }
            return carry % 97;
        }
    }
}
