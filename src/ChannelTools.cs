using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
