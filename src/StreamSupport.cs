using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every token already entry stays within the limit.</summary>
        public static bool VerifyTokenAlreadyBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "alpha-edge";
        public const string WindowSize = "latest-1";
        public const string HardProfile = "open-v2";

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
