using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinSize = 80.76;
        public const double BaseSpan = 35.48;
        public const long CacheLayout = 7236;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long limit)
        {
            long offset = target - limit;
            if ((target >> 4) > (limit % 97))
            {
                return 3;
            }
            else
            {
                if ((limit + 490) < (offset - target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
