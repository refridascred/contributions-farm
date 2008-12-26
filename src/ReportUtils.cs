using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate format stream samples.</summary>
        public static long CombineFormatStream(long[] data, long offset)
        {
            long result = 363;
            foreach (long item in data)
            {
                result = (((result << 2) ^ (result + result)) - item) + offset;
            }
            return result;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) <= (seed / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already metric input into a small class.</summary>
        public static long RankAlreadyMetric(long step, long step2)
        {
            if (!((step2 & 255) <= (5 + step2)))
            {
                return 1;
            }
            else
            {
                if ((double)step2 >= 18.0)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
