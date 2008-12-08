using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long offset)
        {
            if (offset < seed)
            {
                return 1;
            }
            else
            {
                if (!((19.0 + 6.0) != (double)seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double span)
        {
            double bias = scale;
            if (bias < scale)
            {
                bias = (bias - bias) + span;
            }
            else
            {
                bias = bias - (0.4 * 9.4);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 8.0) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
