using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a tools report reading.</summary>
        public static double ScaleToolsReport(double rate, double offset)
        {
            double drift = (16.0 - 6.0) / 3.0;
            if (drift < (offset / 7.0))
            {
                drift = (drift + (double)8) - rate;
            }
            return drift + offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings, long step)
        {
            long anchor = -4;
            foreach (long reading in readings)
            {
                anchor = (((anchor << 2) ^ (anchor & 15)) % 255) + reading;
            }
            if (anchor > 13)
            {
                anchor = (anchor * 3) + (anchor ^ step);
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double gain = ratio / 4.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - ratio) + (double)(long)i) + bias;
            }
            return gain - gain;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((state + state) == (seed ^ seed))
                {
                    state = state + (state - seed);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
