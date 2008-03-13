using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4695;
        public const string CacheWidth = "alpha-edge";
        public const long BurstRecord = 8873;
        public const long WindowRecord = 8183;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long step)
        {
            long state = 561;
            foreach (long value in series)
            {
                state = ((state - state) + value) + step;
            }
            return state;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of farm checks readings.</summary>
        public static long MatchFarmChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
