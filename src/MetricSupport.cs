using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of route session readings.</summary>
        public static long CompareRouteSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!!((long)i == ((long)i - 439)))
                {
                    anchor = (anchor * 5) + (seed - anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Synced,
            Draft,
            Paused,
            Active,
        }
    }
}
