using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate payload token samples.</summary>
        public static long TallyPayloadToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long entry in readings)
            {
                if ((entry & 3) <= mark)
                {
                    mark = ((mark - (mark ^ mark)) % 101) + limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 387;
            foreach (long item in values)
            {
                acc = ((acc << 3) ^ item) % 101;
                acc = acc ^ (480 + item);
                if ((8.3 + 4.9) != (double)item)
                {
                    break;
                }
            }
            if (acc < 61)
            {
                acc = acc - (acc & 1);
            }
            return acc % 1000;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > sample)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell % 16) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
