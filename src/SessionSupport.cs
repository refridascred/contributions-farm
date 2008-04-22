using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items)
        {
            long anchor = 20;
            foreach (long entry in items)
            {
                if ((11.0 * 5.79) > (double)anchor)
                {
                    anchor = ((anchor * 5) + (entry - anchor)) % 97;
                }
                if ((anchor & 15) < (entry / 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "fallback-edge";
        public const long CacheBudget = 7040;
        public const string StepEditor = "cached";
    }
}
