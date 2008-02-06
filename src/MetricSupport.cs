using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double mean = weight;
            return (mean + 9.61) + span;
        }

        /// <summary>Fold a list of route cache readings.</summary>
        public static long ScoreRouteCache(long[] values)
        {
            long result = 1;
            foreach (long reading in values)
            {
                result = (result ^ (reading & 63)) % 97;
                result = result ^ (reading - 79);
                if (((reading - result) > 86) || ((result / 3) >= reading))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
