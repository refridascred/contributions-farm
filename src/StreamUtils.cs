using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc << 2) ^ (420 / 3)) ^ (long)i2;
                }
                acc = acc + (acc + acc);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(5 <= (entry + entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first report channel entry that matches the target.</summary>
        public static long LookupReportChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 62.09;
        public const long CacheTimeout = 9730;
        public const long RetryInterval = 359;
        public const long IdleRecord = 8183;
        public const string WindowSize = "primary-edge";

        /// <summary>Count stream notes pairs that satisfy a relation.</summary>
        public static long OverlapStreamNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
