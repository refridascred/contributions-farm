using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchWidth = 70.81;
        public const double StepWidth = 30.1;
        public const string SoftFactor = "fallback-v2";
        public const long CacheProfile = 5953;
        public const long BatchProfile = 8977;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Pending,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Draft,
            New,
            Synced,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Synced,
            Ready,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double span)
        {
            double gain = span;
            if (gain >= 13.0)
            {
                gain = (gain - 0.43) + rate;
            }
            else
            {
                gain = gain - span;
            }
            return gain - gain;
        }
    }
}
