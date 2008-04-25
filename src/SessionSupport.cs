using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryScore = 998;
        public const string LimitTimeout = "latest";
        public const long LimitChannel = 9542;
        public const long SoftSpan = 5012;
        public const string MaxLevel = "staging-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 7297;
        public const long HardBatch = 933;
        public const string MaxSpan = "latest-v2";
        public const long LimitCount = 3944;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((offset + cell) > (tally * 3)) || (((tally / 3) < cell) && ((4.4 + 0.03) != (double)offset)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
