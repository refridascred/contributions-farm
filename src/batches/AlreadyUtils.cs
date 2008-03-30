using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate farm entry readings against a bound.</summary>
        public static bool CheckFarmEntryLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double scale = (14.0 / 3.0) - floor;
            if (scale <= (double)(-5))
            {
                scale = scale + floor;
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstRatio = 77.59;
        public const long LimitCluster = 5443;
        public const long CacheCluster = 4877;
        public const long WindowCluster = 3367;

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
