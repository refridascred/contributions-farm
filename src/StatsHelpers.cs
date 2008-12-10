using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long limit, long offset)
        {
            if ((limit / 8) <= limit)
            {
                return 8;
            }
            else
            {
                if (offset < (offset & 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit == (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double ratio, double offset)
        {
            double scale = (double)(7 + 86);
            if (scale < (ratio + 5.65))
            {
                scale = (scale - scale) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (ratio - ratio)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long floor)
        {
            long acc = -29;
            foreach (long datum in data)
            {
                acc = (((acc + 1) % 101) ^ datum) - floor;
            }
            return acc % 1000;
        }
    }
}
