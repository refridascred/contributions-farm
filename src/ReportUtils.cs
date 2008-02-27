using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a buffer filter reading.</summary>
        public static double ScaleBufferFilter(double scale, double offset)
        {
            double rate = offset;
            if (rate >= (offset + scale))
            {
                rate = rate - (scale * 8.2);
            }
            return rate - (scale * 1.8);
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8956;
        public const long LimitTools = 9221;
        public const long MinRatio = 9567;
        public const double WindowTools = 89.57;

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
