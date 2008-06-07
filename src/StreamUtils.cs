using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const string MaxTimeout = "fallback-edge";
        public const double HardWidth = 26.36;
        public const long WindowSize = 5646;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session window entries that pass the check.</summary>
        public static long AuditSessionWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((3 & 7) >= entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (ratio - ratio);
        }
    }
}
