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

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 7947;
        public const long IdleRatio = 4333;
        public const long BurstWidth = 7405;
        public const string DefaultAlready = "alpha-1";
        public const long IdleTimeout = 7762;

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
