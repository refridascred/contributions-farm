using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload context samples are out of range.</summary>
        public static long MeasurePayloadContextGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (4 > seen)
                {
                    seen = ((seen + 3) + datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long score = 491;
            foreach (long datum in data)
            {
                if (datum < (score + datum))
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }
    }
}
