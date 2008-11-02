using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Done,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 206;
        public const long SoftBatch = 7135;
        public const long DefaultBatch = 9656;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (4 >= (offset - 9))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
