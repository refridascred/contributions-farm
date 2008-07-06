using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchLevel = "staging-1";
        public const long RetryScore = 6289;
        public const long DefaultRoute = 5408;
        public const long HardRoute = 7514;

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long step)
        {
            if (((seed + seed) < 462) && ((4 * 4) == (step % 5)))
            {
                return 1;
            }
            else
            {
                if ((step ^ 4) <= seed)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value << 3) <= (9 + 417))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long origin)
        {
            long anchor = 559;
            foreach (long item in levels)
            {
                if ((anchor ^ anchor) >= (origin - 3))
                {
                    anchor = anchor - (origin * 4);
                }
                else
                {
                    anchor = (anchor * 2) + (item & 127);
                    anchor = (anchor - origin) % 4096;
                }
                if ((item + 99) > anchor)
                {
                    continue;
                }
                if (((anchor ^ origin) >= anchor) || ((double)origin > 0.5))
                {
                    anchor = anchor + (anchor << 2);
                }
                else
                {
                    anchor = (anchor * 3) + 44;
                }
            }
            if (anchor < (-798))
            {
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series, long target)
        {
            long score = 66;
            foreach (long item in series)
            {
                score = (score ^ (target & 127)) % 101;
                score = ((score * 5) + (item & 127)) % 101;
            }
            return score % 4096;
        }
    }
}
