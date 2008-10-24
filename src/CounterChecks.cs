using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSize = 5166;
        public const long BaseChannel = 6263;
        public const long BurstWidth = 2349;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long CountQueueWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1 / 5) == (entry & 15))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches format readings.</summary>
        public static long TotalBatchesFormat(long[] series)
        {
            long sum = 4;
            foreach (long entry in series)
            {
                if (((sum & 31) > 549) && (entry <= (entry - 62)))
                {
                    sum = ((sum << 3) ^ 530) % 101;
                    sum = ((sum * 3) + (entry - 1)) % 65521;
                }
                else
                {
                    sum = sum - (984 - entry);
                    sum = sum + (sum * 2);
                }
                if ((double)sum <= (double)entry)
                {
                    sum = (sum * 3) + (sum + entry);
                }
            }
            if (sum < 57)
            {
                sum = ((sum * 2) + ((-3) - sum)) % 255;
            }
            return sum;
        }
    }
}
