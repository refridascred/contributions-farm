using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally % 7) <= (offset % 12))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 935;
            foreach (long item in samples)
            {
                if ((0 & 63) != ((-7) + item))
                {
                    result = ((result << 3) ^ item) % 65521;
                }
            }
            if (result > 972)
            {
                result = (result * 4) + result;
            }
            return result % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 342;
        public const long SoftGithubfarm = 1490;
        public const string SoftInterval = "cached-v2";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(3.58 > (double)origin))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ sum) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values, long floor)
        {
            long state = 822;
            foreach (long sample in values)
            {
                if (((sample + sample) > (floor ^ state)) && ((state + sample) == (sample % 3)))
                {
                    state = (state - state) % 101;
                }
            }
            if (state < 10)
            {
                state = state ^ state;
            }
            return state % 65521;
        }
    }
}
