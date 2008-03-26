using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Retry,
            New,
            Locked,
            Stale,
        }

        /// <summary>Classify a cluster queue pair into a bucket.</summary>
        public static long BucketClusterQueue(long floor, long floor2)
        {
            if (((floor2 ^ floor) >= (floor + 73)) && ((2.6 - 0.26) != (double)floor))
            {
                return 2;
            }
            else
            {
                if ((floor * 5) < floor2)
                {
                    return 5;
                }
                else
                {
                    if (5 <= (792 + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 + (-3)) <= (1 ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value == (8.1 + 5.26))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
