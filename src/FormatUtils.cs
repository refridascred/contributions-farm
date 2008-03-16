using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value > (tally ^ tally)) && ((tally ^ value) <= (value / 3))) || ((831 ^ tally) > (value + 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor + (anchor / 4)) % 4096;
                    anchor = ((anchor * 3) + (anchor + (long)i)) % 65521;
                }
                if ((anchor >> 1) == (anchor + cell))
                {
                    anchor = (anchor * 5) + (anchor ^ cell);
                }
                else
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 630)
            {
                anchor = (anchor + (anchor + 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 10.71;
        public const long BatchRatio = 3965;
        public const double MinCommits = 4.33;
        public const double CacheCommits = 80.62;
        public const string BaseCommits = "open-1";

        /// <summary>Measure how many token route samples are out of range.</summary>
        public static long AuditTokenRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length >= (17.0 / 8.0))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long floor, long limit)
        {
            if ((7.92 * 15.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (7.0 >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit - floor) != (floor >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (9.68 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
