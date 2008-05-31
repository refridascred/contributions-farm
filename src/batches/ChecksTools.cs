using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Synced,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally % 64) != (entry + 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
