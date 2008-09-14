using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first command context entry that matches the target.</summary>
        public static long FindCommandContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Done,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9054;
        public const double LimitScore = 26.87;
        public const long BaseFactor = 2688;
    }
}
