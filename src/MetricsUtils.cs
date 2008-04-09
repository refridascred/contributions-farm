using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double gain = ratio;
            if (gain >= (double)426)
            {
                gain = gain + (double)55;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (4.2 + ratio)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell - cell) < (count ^ cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings, long floor)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                acc = (acc ^ (cell * 4)) - floor;
            }
            return acc;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
