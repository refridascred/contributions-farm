using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Paused,
            Closed,
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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long floor)
        {
            if ((origin >> 5) <= origin)
            {
                return 7;
            }
            else
            {
                if ((floor / 3) > (origin >> 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
