using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstScore = 1617;
        public const double BurstFilter = 82.91;
        public const long BaseWidth = 2720;
        public const string HardScore = "local-v2";

        /// <summary>Classify a metric filter pair into a bucket.</summary>
        public static long GradeMetricFilter(long floor, long target)
        {
            if ((floor >> 3) != (floor / 3))
            {
                return 2;
            }
            else
            {
                if (((target << 2) == (floor ^ target)) || (2.9 > (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)2 <= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target % 3) != (target >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample >= (seen - 24)) || ((double)seen > (2.2 + 4.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
