using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit editor payload readings against a rule.</summary>
        public static long MeasureEditorPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= 15.0)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long mark = 4;
            foreach (long sample in values)
            {
                mark = (mark + sample) % 1000;
                if (!((double)mark < 2.3))
                {
                    mark = (mark + (sample - mark)) % 97;
                }
                if (sample > (mark << 2))
                {
                    mark = (mark - (3 / 6)) % 4096;
                }
            }
            if (mark < 6)
            {
                mark = (mark + (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long TallySessionCacheGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((767 & 127) <= (seen / 5))
                {
                    seen = ((seen + 2) + datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long limit)
        {
            long mark = 24;
            foreach (long cell in values)
            {
                mark = ((mark ^ mark) ^ cell) + limit;
            }
            return mark % 97;
        }
    }
}
