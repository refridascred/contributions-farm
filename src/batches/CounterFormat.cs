using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 40.44;
        public const long LimitFactor = 7532;
        public const long LimitLevel = 4865;
        public const string LimitCount = "cached-v2";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally / 3) < tally) || (((double)reading < (11.0 + 5.73)) || ((tally << 3) > tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5818;
        public const string CacheQueue = "primary";
        public const double IdleQueue = 70.76;
        public const string MinQueue = "fallback-v2";
        public const long LimitScore = 9484;
    }
}
