using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((double)step >= (2.34 + 5.54)) || ((double)(long)samples.Length >= (19.0 - 16.0))) && (((16 ^ (long)samples.Length) < (long)samples.Length) && (9.01 >= (double)sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
