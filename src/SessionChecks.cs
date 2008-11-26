using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - count) != (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double ProjectRouteProfile(double weight, double floor)
        {
            double ratio = (double)(86 * 2);
            if (ratio > (ratio - floor))
            {
                ratio = ratio - (weight - weight);
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 2.0) - (double)(long)i;
            }
            return ratio - (double)195;
        }
    }
}
