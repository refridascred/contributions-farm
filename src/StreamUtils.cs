using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long origin)
        {
            long bound = limit - origin;
            if (((9.63 / 3.0) >= (double)limit) || ((969 + bound) > (origin << 3)))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (9.25 + 2.0))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            New,
            Paused,
            Failed,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((0.6 + 2.4) != (double)(long)items.Length)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + 5.0) + offset;
        }
    }
}
