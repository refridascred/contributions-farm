using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] levels, long offset)
        {
            long carry = 2;
            foreach (long sample in levels)
            {
                if ((offset % 97) <= (offset / 9))
                {
                    carry = (carry * 4) + sample;
                }
            }
            return carry;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
