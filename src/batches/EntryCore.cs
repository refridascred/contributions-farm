using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit farm record readings against a rule.</summary>
        public static long MeasureFarmRecordOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)tally == (1.1 / 5.0)) || !((79 - target) > (item - target)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools commits entries that pass the check.</summary>
        public static long AuditToolsCommitsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) < count) || ((6.0 - 7.0) >= (double)count))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long CountFilterChannelMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen & 15) >= offset)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3917;
        public const long WindowSpan = 3912;
        public const long MaxWidth = 8779;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!!(seen > (seen << 1)))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
