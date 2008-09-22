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

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((38 / 4) <= (hits * 2)) || ((5.04 / 4.0) != (double)hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
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
