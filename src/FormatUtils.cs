using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long step)
        {
            long offset = target ^ step;
            if ((target % 10) != (offset << 3))
            {
                return 6;
            }
            else
            {
                if (offset >= target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Retry,
            New,
            Locked,
            Paused,
        }

        /// <summary>Roll a stream layout counter forward.</summary>
        public static long SeriesStreamLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (2.0 / 2.0))
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 - (offset * 3.0);
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Draft,
            Done,
            Idle,
        }
    }
}
