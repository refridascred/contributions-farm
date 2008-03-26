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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items, long bound)
        {
            long state = 930;
            foreach (long entry in items)
            {
                if ((5.73 * 4.68) != (double)state)
                {
                    state = (state ^ (bound % 64)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample & 1) <= (matches + 86)) && ((matches + sample) < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
