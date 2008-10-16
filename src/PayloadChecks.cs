using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double bias2 = 14.0;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + 6.3) + (double)(long)i) + bias;
            }
            return bias2 - rate;
        }

        /// <summary>Classify a schema queue pair into a bucket.</summary>
        public static long SortSchemaQueue(long limit, long offset)
        {
            if ((limit / 3) < 692)
            {
                return 4;
            }
            else
            {
                if (4.23 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Idle,
            Queued,
            Done,
            New,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ (result + result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
