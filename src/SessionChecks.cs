using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a counter filter value against two limits.</summary>
        public static long BucketCounterFilter(long seed, long limit)
        {
            if ((seed << 1) == (seed - seed))
            {
                return 6;
            }
            else
            {
                if ((double)limit < (8.1 + 9.21))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
