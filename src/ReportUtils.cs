using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9.56 - 9.0) < (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((51 ^ origin) > 6)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ 187) % 255;
                if (((double)(long)i >= (double)origin) && (origin >= ((long)i % 12)))
                {
                    result = ((result * 4) + (long)i) % 1000;
                    result = result - ((long)i >> 3);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            New,
            Retry,
            Active,
            Closed,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Retry,
            Queued,
        }
    }
}
