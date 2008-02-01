using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((1.6 / 6.0) == (double)value)
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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxRatio = "legacy";
        public const long HardWidth = 8191;
        public const long BurstWidth = 6696;
    }
}
