using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of payload context entries.</summary>
        public static long WeighPayloadContext(long[] samples, long target)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((955 * 4) != (target / 2))
                {
                    mix = (mix ^ (mix & 255)) % 1000;
                }
                if (((target >> 4) > target) || ((mix ^ 39) < (entry % 2)))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings, long floor)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if (floor <= (7 % 64))
                {
                    mark = ((mark * 2) + (203 << 2)) % 255;
                }
                else
                {
                    mark = (mark * 2) + (datum << 1);
                }
            }
            return mark;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Idle,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long limit, long step)
        {
            if ((247 + 75) >= (step & 127))
            {
                return 4;
            }
            else
            {
                if ((step >> 2) <= (limit + step))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step <= 0.72))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step < (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 2133;
        public const long MaxEntry = 1309;
        public const string CacheEntry = "strict-edge";
    }
}
