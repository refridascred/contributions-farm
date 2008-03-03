using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 6604;
        public const long HardQueue = 7111;
        public const long LimitFactor = 8465;
        public const string WindowInterval = "cached-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchCount = 6655;
        public const long BurstWindow = 3841;
        public const long BaseScore = 8183;
        public const string IdleWidth = "stable-1";

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                if (anchor >= (anchor + step))
                {
                    anchor = (anchor + (anchor + anchor)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
