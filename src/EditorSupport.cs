using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Locked,
            Synced,
            Idle,
            Dropped,
        }

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

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSpan = 6254;
        public const string BatchAccount = "open-edge";
        public const long LimitAccount = 2789;
        public const long BurstAccount = 4058;
        public const string BurstSize = "cached-edge";

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (carry + limit)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (((carry * 3) + carry) % 101) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
