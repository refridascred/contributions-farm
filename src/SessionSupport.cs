using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardWidth = 1405;
        public const long HardRecord = 8291;
        public const string WindowRatio = "latest-1";

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((207 & 7) > tally) || ((double)sample != (15.0 - 2.0))) || ((double)tally != (6.9 - 16.0)))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
