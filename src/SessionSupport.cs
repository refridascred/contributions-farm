using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 250;
        public const double BurstRoute = 84.11;
        public const long WindowDepth = 1171;
        public const long LimitRoute = 9274;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long SeekAccountLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
