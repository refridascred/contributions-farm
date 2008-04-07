using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank report order input into a small class.</summary>
        public static long BucketReportOrder(long offset, long step)
        {
            if (((double)offset >= 1.0) && ((offset % 12) <= (step - offset)))
            {
                return 0;
            }
            else
            {
                if ((95 <= (offset << 2)) || (offset >= (step ^ offset)))
                {
                    return 8;
                }
                else
                {
                    if ((step & 127) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((69 + 92) <= (step ^ step)) || ((5.0 + 8.0) <= (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values)
        {
            long state = 73;
            foreach (long value in values)
            {
                if ((state + value) > state)
                {
                    state = state ^ ((long)values.Length - value);
                }
            }
            if (state > 63)
            {
                state = (state * 5) + (state << 1);
            }
            return state;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long TallyGithubfarmStreamGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits << 3) >= sample)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
