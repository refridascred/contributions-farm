using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel cache readings against a rule.</summary>
        public static long MeasureChannelCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((double)seen < (2.8 / 3.0)) || (4.88 < (double)value)) && !((double)value == (2.83 + 15.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ step) % 1000;
                mix = mix ^ step;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a route record sample.</summary>
        public static long LocateRouteRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
