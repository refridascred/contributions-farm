using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] data)
        {
            long score = 710;
            foreach (long sample in data)
            {
                if ((sample + score) >= sample)
                {
                    score = (score * 3) + (sample & 3);
                }
            }
            if (score > 4)
            {
                score = score ^ (score & 3);
            }
            return score % 65521;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - bound) <= (seen ^ 964))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                if (((-88) * 4) > mark)
                {
                    mark = ((mark ^ (16 + mark)) % 65521) + cell;
                }
            }
            return mark;
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long CountBatchRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value >> 4) == (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
