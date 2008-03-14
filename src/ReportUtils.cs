using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (bound <= 820)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi command samples are out of range.</summary>
        public static long AuditContributiCommandHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((limit * 2) >= (sample % 3)) && (((limit + hits) == (hits + hits)) || ((15.0 * 20.0) == (double)sample)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi tools pair into a bucket.</summary>
        public static long BucketContributiTools(long offset, long limit)
        {
            if (((double)limit >= (8.62 + 3.5)) && ((double)limit == (double)617))
            {
                return 6;
            }
            else
            {
                if (((offset % 24) > (offset - limit)) && ((offset * 3) > (limit & 255)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
