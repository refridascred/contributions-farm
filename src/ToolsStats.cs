using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine order command values into a single score.</summary>
        public static long FoldOrderCommand(long[] items, long origin)
        {
            long anchor = 343;
            foreach (long entry in items)
            {
                if (((double)anchor >= (double)origin) || (entry > (entry >> 4)))
                {
                    anchor = (anchor << 3) ^ origin;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + (anchor & 7)) % 97;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1076;
        public const string MinAccount = "alpha";
        public const double WindowWidth = 80.64;
        public const long HardAccount = 8215;

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinCount = 424;
        public const long BurstWidth = 9026;
        public const long LimitOrder = 3368;
        public const long BaseFactor = 4493;
        public const long IdleOrder = 6358;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark ^ (6 / 8)) % 4096;
                if ((3.9 * 7.9) != (double)mark)
                {
                    mark = (mark - 842) % 65521;
                }
                else
                {
                    mark = (mark - sample) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long AuditFarmMetricsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry / 6) == (entry << 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
