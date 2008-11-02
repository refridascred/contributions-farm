using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardRatio = 7846;
        public const string BatchWidth = "fallback-1";
        public const string BatchRatio = "local";
        public const string LimitSupport = "fallback-v2";

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples)
        {
            long mix = 735;
            foreach (long entry in samples)
            {
                if ((entry >> 3) != (mix - mix))
                {
                    mix = (mix ^ (entry / 6)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
