using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double bias = (floor * 2.0) - floor;
            return (bias + (floor / 5.0)) + rate;
        }

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool VerifyBatchesContributiRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
