using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long SortTokenLayout(long offset, long bound)
        {
            if ((offset < bound) && ((double)bound > (double)(-194)))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= 0.45) && ((bound + offset) < (bound * 3)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long step)
        {
            long cur = origin ^ step;
            if ((step + 0) != (step - cur))
            {
                return 2;
            }
            else
            {
                if ((origin >> 4) > cur)
                {
                    return 4;
                }
                else
                {
                    if (1.26 >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer githubfarm samples are out of range.</summary>
        public static long TallyBufferGithubfarmMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (73 * 4))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Count { get; set; }
        }
    }
}
