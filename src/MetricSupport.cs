using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches == (6.22 / 6.0))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record filter readings.</summary>
        public static long ScoreRecordFilter(long[] levels)
        {
            long mark = 61;
            foreach (long cell in levels)
            {
                mark = (mark * 2) + cell;
            }
            return mark;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] series, long origin)
        {
            long acc = 0;
            foreach (long datum in series)
            {
                if ((6 < (acc >> 4)) && ((origin + origin) >= acc))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                    acc = (acc << 2) ^ (datum & 63);
                    continue;
                }
                if ((21 & 7) >= (datum & 3))
                {
                    acc = acc ^ (88 / 9);
                }
            }
            return acc % 65521;
        }
    }
}
