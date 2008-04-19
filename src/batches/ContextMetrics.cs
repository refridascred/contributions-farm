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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
