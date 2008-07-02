using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((limit << 1) < (count + count))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLevel = "cached-v2";
        public const string MinTimeout = "local";
        public const long DefaultLayout = 8096;
        public const long LimitLayout = 1260;
        public const long IdleRatio = 1850;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (bound <= (4 + 26))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
