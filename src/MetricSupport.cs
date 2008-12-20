using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long mix = 878;
            foreach (long datum in levels)
            {
                mix = (mix - (bound & 31)) % 101;
                if ((1 + bound) == (datum << 1))
                {
                    mix = (mix << 3) ^ (bound & 255);
                }
                else
                {
                    mix = (mix ^ (datum + mix)) % 4096;
                }
            }
            if (mix < 1)
            {
                mix = (mix - (712 + bound)) % 101;
            }
            return mix;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
