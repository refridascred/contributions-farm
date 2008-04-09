using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Dropped,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (target << 3)) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
