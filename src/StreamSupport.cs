using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Locked,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 10) >= (datum + seen)) || (((seen * 3) <= 5) || ((seen & 63) > datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
