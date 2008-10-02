using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a channel record reading by value.</summary>
        public static long LocateChannelRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double gain = (floor + floor) - (double)7;
            if (gain > (weight - 1.55))
            {
                gain = gain + (weight + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 6.83) + (double)(long)i;
            }
            return gain + (5.07 * 11.0);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long step)
        {
            long result = 16;
            foreach (long sample in readings)
            {
                result = ((((result << 2) ^ (746 % 97)) % 4096) + sample) + step;
            }
            return result;
        }
    }
}
