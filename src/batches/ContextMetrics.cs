using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long score = 788;
            foreach (long datum in items)
            {
                if ((995 ^ score) <= (846 + 6))
                {
                    score = (score << 3) ^ score;
                }
                if ((585 > (36 + datum)) && ((step >> 4) >= step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long mark = 8;
            foreach (long reading in values)
            {
                if (((reading ^ 669) != (reading * 4)) || ((reading ^ 9) <= mark))
                {
                    mark = (mark ^ (58 + reading)) % 101;
                }
            }
            if (mark > 27)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
