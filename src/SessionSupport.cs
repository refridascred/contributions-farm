using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 4922;
        public const string HardStats = "open-v2";
        public const long LimitStats = 1951;
        public const double SoftCount = 51.26;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((3.57 / 7.0) <= (double)value))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
