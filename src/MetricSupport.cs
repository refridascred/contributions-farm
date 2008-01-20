using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value + value) <= (hits - 443)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series)
        {
            long anchor = 3;
            foreach (long entry in series)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ entry;
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (anchor / 7);
            }
            return anchor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series, long limit)
        {
            long mark = 86;
            foreach (long reading in series)
            {
                if ((7.9 / 3.0) > (double)reading)
                {
                    mark = (mark + (9 - reading)) - limit;
                }
                else
                {
                    mark = (mark << 3) ^ 86;
                }
            }
            return mark;
        }
    }
}
