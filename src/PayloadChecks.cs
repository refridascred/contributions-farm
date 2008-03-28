using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Retry,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long seed)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= 8.0)
                {
                    sum = (sum * 2) + (entry - seed);
                    sum = (sum - entry) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (entry + seed)) % 255;
                    sum = ((sum << 3) ^ (438 >> 2)) % 97;
                }
                if (((double)sum != (double)entry) || ((double)61 != (double)sum))
                {
                    sum = (sum ^ entry) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((9.4 - 6.4) != (double)reading) && ((23 ^ 0) >= (matches + reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7546;
        public const long BurstCluster = 4778;
        public const double StepSize = 46.28;
    }
}
