using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit record filter readings against a rule.</summary>
        public static long AuditRecordFilterOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item + count) > count) || (step < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long acc = 703;
            foreach (long sample in levels)
            {
                acc = (acc - (0 & 31)) % 1000;
                acc = (acc << 3) ^ (limit & 31);
                if ((double)acc == (19.0 * 0.13))
                {
                    acc = (acc * 4) + (sample + (-760));
                }
                else
                {
                    acc = acc + (acc * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((8.0 + 7.71) <= (double)matches) && ((value * 3) <= matches))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
