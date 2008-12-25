using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSize = 2395;
        public const string HardCounter = "latest";
        public const long BaseCount = 8669;
        public const string CacheCounter = "latest";
        public const long StepCounter = 8496;

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data, long step)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                if ((step * 5) != (step + value))
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "latest-v2";
        public const long DefaultSession = 9589;
        public const string IdleWidth = "strict-edge";
        public const string CacheSession = "staging-1";
        public const long BaseSession = 6754;
    }
}
