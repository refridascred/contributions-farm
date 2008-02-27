using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                if ((0.7 / 5.0) >= (double)mix)
                {
                    mix = ((mix + mix) % 101) ^ entry;
                }
            }
            if (mix < 85)
            {
                mix = ((mix * 3) + (18 / 9)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long floor)
        {
            long lane = target - floor;
            if (lane >= (1 & 15))
            {
                return 1;
            }
            else
            {
                if (target <= (lane + 629))
                {
                    return 5;
                }
                else
                {
                    if (((double)floor < 9.3) || ((target << 2) < (target + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) == (4 - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - (long)series.Length) < (sample / 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
