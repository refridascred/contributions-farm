using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 24) >= (reading >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 1392;
        public const long BatchRoute = 2720;
        public const long StepRoute = 5363;
        public const string IdleFactor = "cached-1";
        public const long BatchTimeout = 401;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
