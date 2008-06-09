using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit queue profile readings against a rule.</summary>
        public static long AuditQueueProfileGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item / 6) > item)
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "staging-v2";
        public const string SoftWidth = "staging-edge";
        public const long CacheEditor = 2515;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long limit)
        {
            long acc = 51;
            foreach (long item in series)
            {
                if ((double)acc != (7.0 * 9.28))
                {
                    continue;
                }
                else
                {
                    acc = (acc - (acc ^ limit)) + item;
                }
                acc = acc + (limit << 1);
            }
            if (acc > 5)
            {
                acc = ((acc * 2) + ((long)series.Length - limit)) % 97;
            }
            return acc % 97;
        }
    }
}
