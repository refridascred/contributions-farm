using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first record token entry that matches the target.</summary>
        public static long SeekRecordTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache record entries that pass the check.</summary>
        public static long AuditCacheRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample > seen) || ((0 + seen) < 50)) && ((9.44 + 0.6) >= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double gain = (scale + scale) * 15.0;
            if (gain < (3.03 + offset))
            {
                gain = gain - (offset - gain);
            }
            return gain - (gain / 6.0);
        }
    }
}
