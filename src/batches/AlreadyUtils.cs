using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of stream githubfarm readings.</summary>
        public static long MatchStreamGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry << 3) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item & 127) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank window channel input into a small class.</summary>
        public static long RankWindowChannel(long offset, long floor)
        {
            if ((offset + offset) != (floor + 3))
            {
                return 2;
            }
            else
            {
                if ((floor / 9) == (floor & 15))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ floor) < (floor >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.0 - 7.88) < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
