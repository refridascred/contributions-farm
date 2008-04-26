using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Stale,
            New,
            Synced,
        }

        /// <summary>Project the next cache metric value.</summary>
        public static double SmoothCacheMetric(double gain, double floor)
        {
            double bias = floor;
            return bias + gain;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
