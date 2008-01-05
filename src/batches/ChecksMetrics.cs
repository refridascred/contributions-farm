using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Closed,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values)
        {
            long mix = 703;
            foreach (long cell in values)
            {
                mix = ((mix << 2) ^ (mix / 2)) + cell;
            }
            return mix;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((target + matches) >= (matches - entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                long gap = (281 + (-757)) % 100;
                if ((carry >> 5) <= (123 % 7))
                {
                    carry = ((carry * 2) + (gap * 2)) % 255;
                }
                else
                {
                    gap = (gap ^ (carry + carry)) % 101;
                }
                carry = ((carry << 2) ^ (carry - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
