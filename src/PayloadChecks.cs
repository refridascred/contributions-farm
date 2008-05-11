using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < matches)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long carry = 0;
            foreach (long item in series)
            {
                carry = (carry + (item * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the metric context series from a seed.</summary>
        public static long RollMetricContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 2) ^ (target - target)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
