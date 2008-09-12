using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long floor)
        {
            long offset = seed ^ floor;
            if ((floor % 16) > offset)
            {
                return 2;
            }
            else
            {
                if (((double)seed < (double)94) || (((-14) - 775) > (seed / 6)))
                {
                    return 6;
                }
                else
                {
                    if (((631 + seed) >= offset) || (floor > offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((4.92 / 6.0) == (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long state = 3;
            foreach (long sample in series)
            {
                state = ((state * 4) + state) % 101;
                if ((1.47 / 3.0) > (double)limit)
                {
                    state = (state << 3) ^ (sample + 2);
                }
            }
            if (state < 490)
            {
                state = state - (limit / 4);
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 8) >= ((long)series.Length ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
