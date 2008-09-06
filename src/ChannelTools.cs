using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a format stream sample.</summary>
        public static long FindFormatStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
