using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double rate = bias;
            return (rate + 11.0) + floor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Count the command counter entries that pass the check.</summary>
        public static long AuditCommandCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - tally) >= 405)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
