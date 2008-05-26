using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3121;
        public const string HardBudget = "strict";
        public const double CacheBudget = 50.07;
        public const long HardPayload = 4440;
        public const long SoftPayload = 6456;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
