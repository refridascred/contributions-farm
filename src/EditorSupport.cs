using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((seed + seed) != (seed * 4)) && ((hits * 4) > (seed + hits))) || ((5 - 164) < (seed << 2)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes contributi value.</summary>
        public static double ProjectNotesContributi(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 - rate) + (double)(long)i) + span;
            }
            return rate2 + rate;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Count context metric pairs that satisfy a relation.</summary>
        public static long MatchContextMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a order queue reading.</summary>
        public static double AdjustOrderQueue(double ratio, double span)
        {
            double weight = (ratio / 6.0) + 6.15;
            if (weight < weight)
            {
                weight = weight + (span / 5.0);
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            return weight + ratio;
        }
    }
}
