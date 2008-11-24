using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 4630;
        public const long BatchScore = 3881;
        public const long IdleRatio = 3727;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}
