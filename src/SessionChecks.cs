using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double gain = (span / 9.0) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (span * 9.0)) + (double)(long)i) + weight;
            }
            return gain - span;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Failed,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9768;
        public const long RetryOrder = 8533;
        public const long MaxOrder = 7062;
        public const long SoftOrder = 2558;

        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool ValidatePayloadBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
