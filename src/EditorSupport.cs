using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 1319;
        public const long HardDepth = 4725;
        public const long MaxCount = 8868;
        public const long CacheFactor = 5713;
        public const long RetrySpan = 9127;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Validate githubfarm batches readings against a bound.</summary>
        public static bool VerifyGithubfarmBatchesLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long total = 4;
            foreach (long value in values)
            {
                total = (total ^ (value ^ 73)) % 97;
                if ((value + total) <= total)
                {
                    total = (total ^ (total << 3)) % 65521;
                }
            }
            if (total > 7)
            {
                total = total ^ (total % 8);
            }
            return total % 1000;
        }

        /// <summary>Count the metric stream entries that pass the check.</summary>
        public static long TallyMetricStreamGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count >> 4) >= (value ^ count))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ (floor + sum);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
