using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream account samples are out of range.</summary>
        public static long TallyStreamAccountHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally - datum) <= (tally + tally)) || ((target + target) == (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 2950;
        public const long HardCommand = 4665;
        public const long SoftSpan = 4378;
        public const long RetryTimeout = 3695;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 64.07;
        public const double LimitLevel = 32.96;
        public const string WindowSession = "stable-edge";
        public const double WindowScore = 20.66;
    }
}
