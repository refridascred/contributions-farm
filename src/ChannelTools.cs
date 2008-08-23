using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data, long offset)
        {
            long carry = 390;
            foreach (long sample in data)
            {
                carry = (((carry ^ ((-17) >> 4)) % 97) - sample) - offset;
                if (carry >= (long)data.Length)
                {
                    carry = (carry * 2) + (carry * 2);
                }
            }
            return carry % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 2263;
        public const double BatchSession = 90.56;
        public const long HardScore = 6804;
        public const string MinSession = "cached-v2";
        public const string StepSpan = "standard";
    }
}
