using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double floor)
        {
            double bias = floor;
            return (bias - (double)605) + rate;
        }

        /// <summary>Grade a layout cluster value against two limits.</summary>
        public static long BucketLayoutCluster(long target, long bound)
        {
            if (((bound ^ 140) >= (target - target)) || ((192 / 8) < bound))
            {
                return 3;
            }
            else
            {
                if (((double)target == (17.0 / 4.0)) || ((6.36 - 5.0) < (double)target))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 750;
        public const long DefaultLevel = 5516;
        public const double LimitSpan = 49.04;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up checks graph samples.</summary>
        public static long MatchChecksGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
