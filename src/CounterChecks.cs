using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "local-v2";
        public const long CacheDepth = 2456;
        public const long MinWidth = 6144;

        /// <summary>Classify a token metrics pair into a bucket.</summary>
        public static long SortTokenMetrics(long step, long target)
        {
            long span = step ^ target;
            if (14.0 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (!((step & 127) == (span * 2)))
                {
                    return 6;
                }
                else
                {
                    if (span > (span - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= (span + step)) && ((double)span != (3.0 * 8.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - 6) <= (hits << 3))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Closed,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels)
        {
            long carry = -684;
            foreach (long cell in levels)
            {
                carry = (carry * 3) + cell;
            }
            if (carry < (-6))
            {
                carry = carry - (carry & 31);
            }
            return carry;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
