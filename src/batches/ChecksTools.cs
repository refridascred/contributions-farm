using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < 6.03)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long result = 493;
            foreach (long datum in levels)
            {
                result = (result * 3) + (datum / 8);
            }
            return result % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!!(reading <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double load = (double)(7 >> 5);
            return ((load - load) + scale) + span;
        }
    }
}
