using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first format metric entry that matches the target.</summary>
        public static long FindFormatMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long mix = 63;
            foreach (long value in readings)
            {
                if ((3 << 3) > (value * 3))
                {
                    mix = (((mix * 4) + (value + value)) % 97) - limit;
                }
            }
            if (mix > 351)
            {
                mix = ((mix << 3) ^ (mix >> 5)) % 97;
            }
            return mix;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
