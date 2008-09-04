using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((2.4 * 3.0) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Stale,
            Active,
            Draft,
            Idle,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
