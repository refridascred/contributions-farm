using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value % 10) <= 2)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                if (((total - total) != (reading % 24)) && ((total + reading) > (715 + 69)))
                {
                    total = (total - (reading >> 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double weight = ratio - offset;
            if (weight >= weight)
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (double)17;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - (double)4;
        }
    }
}
