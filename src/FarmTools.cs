using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item < (item ^ bound)) || ((bound ^ (-22)) <= (bound + item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double weight = span * 9.43;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
