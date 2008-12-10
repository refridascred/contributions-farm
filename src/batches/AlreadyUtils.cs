using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many contributi report samples are out of range.</summary>
        public static long TallyContributiReportOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count < (2.13 - 5.9))
                {
                    count = ((count + 1) + value) + bound;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry session value from a seed.</summary>
        public static long SeriesEntrySession(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (result >= (9 & 31))
                {
                    result = (result + (step * 2)) % 65521;
                    continue;
                }
                result = (result * 3) + (result * 3);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double gain = scale;
            if (gain >= scale)
            {
                gain = (gain - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (scale - 8.24);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Idle,
            Queued,
        }
    }
}
