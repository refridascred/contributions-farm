using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel cache readings.</summary>
        public static long ScoreChannelCache(long[] values, long seed)
        {
            long mark = 91;
            foreach (long item in values)
            {
                if ((seed - mark) < (seed % 10))
                {
                    mark = ((mark << 3) ^ (-620)) % 4096;
                }
                if ((double)seed <= 4.83)
                {
                    mark = mark ^ (mark + mark);
                    mark = (mark << 2) ^ ((-3) - seed);
                    continue;
                }
                if (((double)mark < (9.0 + 7.2)) && (item <= seed))
                {
                    mark = mark ^ seed;
                }
                else
                {
                    mark = (mark + (seed / 5)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total + (4 + (long)i);
                total = ((total * 4) + (origin / 4)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
