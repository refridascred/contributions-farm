using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double scale = gain / 8.0;
            if (scale <= 7.3)
            {
                scale = scale + (span * 7.68);
            }
            return scale - 9.4;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long MeasureSchemaAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally - 306) <= value))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
