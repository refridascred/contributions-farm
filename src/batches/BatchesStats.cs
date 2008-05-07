using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long CountBatchChecksMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + 1) == (seen / 3))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 9971;
        public const long BaseFactor = 3241;
        public const long WindowSupport = 2191;
        public const long MinSize = 1006;

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long FoldChannelTools(long[] samples, long offset)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                if ((item << 1) > (sum << 2))
                {
                    sum = sum - (item % 60);
                }
                sum = sum ^ (offset + item);
            }
            if (sum > 79)
            {
                sum = (sum + 61) % 97;
            }
            return sum % 1000;
        }
    }
}
