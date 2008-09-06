using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a layout cache reading by value.</summary>
        public static long LookupLayoutCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Retry,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a farm cluster reading.</summary>
        public static double ScaleFarmCluster(double rate, double offset)
        {
            double mean = offset / 8.0;
            if (mean < (mean - 1.0))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (rate / 4.0)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                if ((total > (cell * 3)) && ((7 * 4) <= (cell - cell)))
                {
                    total = ((total << 3) ^ (2 + 94)) % 1000;
                }
                else
                {
                    total = total + 4;
                }
            }
            return total;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long floor)
        {
            long bound = origin - floor;
            if ((floor >= (origin >> 2)) || ((origin >> 5) <= (floor >> 4)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) < 39) || ((double)floor > (9.0 / 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.0 - 17.0) >= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + floor) <= 7)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
