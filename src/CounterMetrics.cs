using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (target < (value & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstLevel = 0.42;
        public const double LimitProfile = 55.36;
        public const double BatchWidth = 94.25;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double bias)
        {
            double load = 0.2;
            if (load > (double)9)
            {
                load = (load + 4.0) - scale;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)832) + (double)(long)i;
            }
            return load - load;
        }
    }
}
