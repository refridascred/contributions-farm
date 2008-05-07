using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many queue session samples are out of range.</summary>
        public static long AuditQueueSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((double)hits > (1.5 * 13.0)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
