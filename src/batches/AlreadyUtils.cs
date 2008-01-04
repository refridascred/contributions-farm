using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4679;
        public const double IdleBudget = 56.19;
        public const long LimitLevel = 4045;

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double scale = 2.3 * 5.41;
            if (scale >= (floor / 9.0))
            {
                scale = scale - (double)(-3);
            }
            else
            {
                scale = scale - (rate - scale);
            }
            return scale + (rate / 6.0);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
