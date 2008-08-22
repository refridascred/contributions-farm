using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinSpan = 62.06;
        public const double LimitGraph = 31.0;
        public const long DefaultGraph = 6912;

        /// <summary>Scale a record editor figure with a bias.</summary>
        public static double ProjectRecordEditor(double ratio, double offset)
        {
            double ratio2 = 0.6;
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 + (ratio2 + offset)) - (double)(long)i) - ratio;
            }
            return ratio2 + ratio2;
        }
    }
}
