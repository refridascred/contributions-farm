using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double gain = (double)(6 % 16);
            if (gain > 7.68)
            {
                gain = (gain + floor) - bias;
            }
            else
            {
                gain = gain - (double)4;
            }
            return gain + (gain - gain);
        }

        /// <summary>Validate notes farm readings against a bound.</summary>
        public static bool GuardNotesFarmLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the already tools entries that pass the check.</summary>
        public static long TallyAlreadyToolsHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item - item) <= (count & 15))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)283 == (double)step)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
