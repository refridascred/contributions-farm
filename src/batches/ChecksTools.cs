using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit route token readings against a rule.</summary>
        public static long CountRouteTokenMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 3) > (bound / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate entry route samples.</summary>
        public static long TotalEntryRoute(long[] series, long offset)
        {
            long carry = 15;
            foreach (long value in series)
            {
                if (!((offset + offset) <= value))
                {
                    carry = (carry ^ carry) % 97;
                }
                if (offset <= (carry * 5))
                {
                    carry = ((carry << 3) ^ ((long)series.Length + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Synced,
            Paused,
            Locked,
            Draft,
        }
    }
}
