using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCount = 43.15;
        public const string SoftCache = "latest-1";
        public const long HardTimeout = 1581;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (5.6 / 5.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
