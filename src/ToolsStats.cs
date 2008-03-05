using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((599 + cell) < (69 + cell)) && ((target + seen) < (target / 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = 5;
            foreach (long item in readings)
            {
                mix = ((mix + mix) % 4096) + item;
            }
            if (mix > 6)
            {
                mix = (mix + (mix << 1)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings, long origin)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                score = score ^ (origin + reading);
                if ((2.0 - 5.0) < (double)score)
                {
                    score = ((score << 2) ^ (score >> 1)) % 97;
                }
            }
            if (score > (-44))
            {
                score = score + ((-83) + score);
            }
            return score;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry < (4.4 * 7.76))
                {
                    carry = (carry ^ limit) % 65521;
                    continue;
                }
                if ((-778) > (limit + 400))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
