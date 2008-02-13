using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((18.0 * 4.9) > (double)(long)items.Length)
                {
                    tally = ((tally + 1) + cell) + floor;
                }
            }
            return tally;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double bias)
        {
            double scale = 14.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale + scale) + (double)(long)i) - gain) - bias;
            }
            return scale + 7.82;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Locked,
            Done,
            Queued,
        }
    }
}
