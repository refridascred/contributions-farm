using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSize = 63.27;
        public const long IdleTimeout = 4284;
        public const long MinAlready = 6005;
        public const long CacheDepth = 1671;
        public const double MaxTimeout = 32.69;

        /// <summary>Grade a graph record value against two limits.</summary>
        public static long ClassifyGraphRecord(long step, long seed)
        {
            long slot = step - seed;
            if (!((step - step) <= (step + 295)))
            {
                return 3;
            }
            else
            {
                if ((slot - step) > (step - 20))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
