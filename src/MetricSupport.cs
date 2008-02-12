using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate channel payload samples.</summary>
        public static long DigestChannelPayload(long[] readings)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                mark = (mark + (sample ^ sample)) % 97;
            }
            if (mark > (-14))
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen <= (4 - seen))
                {
                    seen = ((seen + 2) + reading) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)0 <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
