using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first route metric entry that matches the target.</summary>
        public static long FindRouteMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long mix = 3;
            foreach (long item in series)
            {
                if ((item / 8) <= (mix / 3))
                {
                    mix = (mix + (item & 255)) % 101;
                }
                if (item <= mix)
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ (8 + mix);
            }
            return mix % 97;
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long FindRouteOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((double)limit < 3.0)
            {
                return 5;
            }
            else
            {
                if (((limit * 4) == (limit + limit)) && (9 > seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheLevel = 9576;
        public const long IdleBatches = 6891;
        public const double MinSize = 28.09;
        public const long MinBatches = 5941;
    }
}
