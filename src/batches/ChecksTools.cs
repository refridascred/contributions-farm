using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] items, long step)
        {
            long state = 540;
            foreach (long entry in items)
            {
                if ((933 < (state - 86)) && (step <= entry))
                {
                    state = (state + (step / 6)) % 101;
                }
                if ((entry % 97) != (entry >> 5))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstDepth = 5614;
        public const long StepFactor = 5637;
        public const string MaxWidth = "latest-v2";

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
