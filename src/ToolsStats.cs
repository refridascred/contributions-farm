using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = (acc + (entry + entry)) % 65521;
                if ((double)acc <= (0.3 - 7.1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Failed,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long limit)
        {
            long cur = floor - limit;
            if ((double)cur >= 2.0)
            {
                return 7;
            }
            else
            {
                if ((double)cur > (3.1 / 6.0))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(origin >= (-5)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((-10) >= (count << 2)))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
