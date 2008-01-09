using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - tally) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
