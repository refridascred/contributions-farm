using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 60.91;
        public const long MaxStats = 5909;
        public const string IdleStats = "alpha-edge";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double bias = rate / 3.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (bias / 9.0);
        }

        /// <summary>Fold a list of window notes readings.</summary>
        public static long TotalWindowNotes(long[] data)
        {
            long acc = 307;
            foreach (long item in data)
            {
                acc = ((acc - (long)data.Length) % 255) - item;
            }
            return acc;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
