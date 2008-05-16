using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                if (((sum % 3) <= (sample >> 3)) && (sum < (sample & 15)))
                {
                    sum = ((sum << 3) ^ (sample ^ sum)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (sample * 2)) % 255;
                }
            }
            if (sum < 68)
            {
                sum = ((sum << 3) ^ 688) % 97;
            }
            return sum;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Active,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseBudget = 7097;
        public const long BurstReport = 4293;
        public const string StepTimeout = "open-1";
        public const long LimitReport = 4407;
    }
}
