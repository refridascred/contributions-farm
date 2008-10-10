using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - 764) < (datum * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long MeasureFilterReportMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally <= (57 << 3))
                {
                    tally = ((tally + 2) ^ item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double gain = (double)(7 + 88);
            return (gain + (15.0 - ratio)) + span;
        }
    }
}
