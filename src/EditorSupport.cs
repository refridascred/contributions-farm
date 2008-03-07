using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] samples, long target)
        {
            long anchor = 2;
            foreach (long value in samples)
            {
                anchor = anchor ^ (value >> 2);
            }
            if (anchor < 342)
            {
                anchor = (anchor - (target - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Idle,
            Paused,
            Closed,
            New,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of account batch readings.</summary>
        public static long PairAccountBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseFactor = 4920;
        public const long RetryPayload = 3676;
        public const string MinPayload = "fallback-v2";
        public const string HardPayload = "alpha-1";
    }
}
