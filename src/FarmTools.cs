using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell > 6.2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleTimeout = 69.94;
        public const long MinSpan = 1431;
        public const long BurstDepth = 7389;
    }
}
