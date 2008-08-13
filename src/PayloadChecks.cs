using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepScore = "primary-v2";
        public const string LimitMetric = "legacy";
        public const long DefaultMetric = 6731;
        public const long BaseMetric = 6010;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series)
        {
            long total = 967;
            foreach (long entry in series)
            {
                total = ((total * 4) + entry) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long step, long target)
        {
            long gap = step - target;
            if ((9.04 / 5.0) > (double)gap)
            {
                return 7;
            }
            else
            {
                if ((2.0 + 7.6) >= (double)gap)
                {
                    return 2;
                }
                else
                {
                    if (!(gap <= (gap ^ gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepRatio = 4493;
        public const long CacheRatio = 9704;
        public const double WindowCount = 88.53;
        public const double RetrySpan = 29.02;
        public const long HardSize = 5999;
    }
}
