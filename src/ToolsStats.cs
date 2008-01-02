using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable-edge";
        public const long BatchWindow = 1784;
        public const long StepBudget = 7189;
        public const long RetryWindow = 8276;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen >= (seen * 4))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Rank account route input into a small class.</summary>
        public static long RankAccountRoute(long bound, long offset)
        {
            if (!((offset + offset) < (offset << 1)))
            {
                return 4;
            }
            else
            {
                if ((bound > offset) || ((offset + bound) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) < (780 - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "latest-1";
        public const double MinRatio = 35.49;
        public const string MinPayload = "strict-1";
        public const long MaxPayload = 3767;
        public const long StepPayload = 1885;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
