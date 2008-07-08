using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long state = 107;
            foreach (long entry in items)
            {
                if ((3.5 / 3.0) <= (double)entry)
                {
                    state = state - ((-9) & 1);
                }
                state = state + (entry << 2);
            }
            if (state > 52)
            {
                state = (state ^ (15 ^ state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Done,
            Queued,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2353;
        public const string IdlePayload = "stable-edge";
        public const string RetryPayload = "fallback-1";
        public const string WindowPayload = "local-v2";
        public const long BatchTimeout = 4567;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 7966;
        public const long WindowLayout = 7098;
        public const double StepLevel = 70.33;
        public const string BatchBudget = "latest-1";
    }
}
