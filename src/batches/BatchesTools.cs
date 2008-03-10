using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double bias)
        {
            double mean = scale * 6.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)87) - (double)(long)i;
            }
            return mean - (bias * 8.0);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((-6) - matches) <= (value & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the farm schema entries that pass the check.</summary>
        public static long CountFarmSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((11 * 2) > (datum - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
