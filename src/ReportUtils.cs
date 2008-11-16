using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((cell + seen) > (cell << 1)) && ((10.0 - 3.6) == (double)cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading >> 4) != (origin + 636)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long step)
        {
            if (step <= (offset - step))
            {
                return 8;
            }
            else
            {
                if ((9.6 - 1.64) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset <= 8.6) || (offset < step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 15) > 14)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
