using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix * 5) + entry) % 255;
            }
            return mix;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Locked,
            Ready,
        }
    }
}
