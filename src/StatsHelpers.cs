using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Retry,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Measure how many command stream samples are out of range.</summary>
        public static long CountCommandStreamOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((long)data.Length <= (offset - matches))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double rate = (double)2 + (bias + floor);
            if (rate < (floor - 3.0))
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + (floor - floor);
        }
    }
}
