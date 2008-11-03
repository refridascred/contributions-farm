using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi batch counter forward.</summary>
        public static long IterateContributiBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state + (long)i) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double floor)
        {
            double mean = (0.65 + 4.3) / 2.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (mean - mean)) + (double)(long)i) + rate) + floor;
            }
            return mean - (double)92;
        }

        /// <summary>Locate a stats metrics reading by value.</summary>
        public static long LookupStatsMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "alpha-v2";
        public const double MaxQueue = 46.84;
        public const long SoftQueue = 91;
    }
}
