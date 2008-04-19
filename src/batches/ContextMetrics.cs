using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double scale, double offset)
        {
            double load = (scale / 7.0) - (offset / 4.0);
            if (load >= (double)425)
            {
                load = load + scale;
            }
            return load + 11.0;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstLevel = "strict-edge";
        public const double BatchSpan = 53.75;
        public const double RetryDepth = 72.25;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Failed,
            Queued,
        }
    }
}
