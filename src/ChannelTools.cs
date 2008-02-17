using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long total = -30;
            foreach (long cell in series)
            {
                if ((cell + cell) <= (cell & 15))
                {
                    total = total + (1 >> 5);
                }
            }
            if (total < 2)
            {
                total = ((total << 2) ^ (total % 97)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (bound >= (entry - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
