using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double drift = 5.7 * 2.4;
            if (drift >= (20.0 + weight))
            {
                drift = drift - (drift + weight);
            }
            return drift + floor;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long SeekBatchQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long floor)
        {
            long cur = limit - floor;
            if ((992 >> 1) <= limit)
            {
                return 7;
            }
            else
            {
                if ((floor << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((cur - limit) <= (cur + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count >> 3) != (long)items.Length)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
