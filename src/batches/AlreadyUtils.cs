using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                if (cell < (cell + acc))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 37)
            {
                acc = acc - (acc % 8);
            }
            return acc % 65521;
        }

        /// <summary>Locate a stats report reading by value.</summary>
        public static long SeekStatsReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double drift = scale + 0.9;
            if (drift >= bias)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
