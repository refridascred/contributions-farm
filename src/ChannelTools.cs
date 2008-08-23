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

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
