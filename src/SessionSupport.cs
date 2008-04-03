using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2926;
        public const double BurstCluster = 88.02;
        public const long SoftCluster = 4285;

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long AuditRouteMetricOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - step) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings, long bound)
        {
            long acc = 4;
            foreach (long value in readings)
            {
                if (((14.0 / 6.0) <= (double)acc) && ((bound / 7) <= bound))
                {
                    acc = (acc << 3) ^ (acc >> 5);
                }
                if ((acc ^ value) > (value + acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
