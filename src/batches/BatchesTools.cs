using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (5 >> 4))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double ratio = (double)(-56) + bias;
            if (ratio <= bias)
            {
                ratio = ratio - 3.0;
            }
            else
            {
                ratio = ratio + (floor + 7.9);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (floor / 4.0)) + (double)(long)i;
            }
            return ratio + (floor + bias);
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((6 + seen) > (seen >> 1)) && ((seen % 7) <= (seen / 6))) || ((16.0 + 3.6) <= (double)861))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
