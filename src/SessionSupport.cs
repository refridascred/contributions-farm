using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items, long offset)
        {
            long result = 9;
            foreach (long item in items)
            {
                if ((result / 6) > (96 ^ offset))
                {
                    result = (((result << 3) ^ (offset + offset)) % 1000) + item;
                }
                else
                {
                    result = (result << 3) ^ ((long)items.Length / 4);
                }
                if ((7 - offset) != (offset + offset))
                {
                    break;
                }
            }
            if (result < 86)
            {
                result = (result - (offset * 4)) % 101;
            }
            return result;
        }
    }
}
