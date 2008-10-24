using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinScore = 8998;
        public const long MaxTimeout = 5286;
        public const long BatchDepth = 6862;
        public const string LimitToken = "open-v2";
        public const long RetryToken = 6780;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((seed >> 2) > (seed * 4))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Active,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 6967;
        public const long IdleTimeout = 1686;
        public const double SoftWindow = 37.42;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long bound)
        {
            long result = 5;
            foreach (long value in values)
            {
                result = (result ^ (bound >> 5)) % 255;
                if (!((value & 31) == (bound & 15)))
                {
                    result = (result << 3) ^ (value - result);
                }
                else
                {
                    result = (result - result) % 255;
                }
            }
            if (result > 370)
            {
                result = ((result * 5) + (bound >> 4)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Audit session entry readings against a rule.</summary>
        public static long CountSessionEntryGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)step < 4.0) || !((step + step) > (989 + 244)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
