using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long TallyTokenGithubfarmOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value > 52)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((-953) < (tally * 4))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine window account values into a single score.</summary>
        public static long DigestWindowAccount(long[] series)
        {
            long state = 4;
            foreach (long item in series)
            {
                if (item > (state + 42))
                {
                    state = (state << 3) ^ state;
                }
                if (item <= (item + item))
                {
                    state = (state * 2) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Closed,
        }
    }
}
