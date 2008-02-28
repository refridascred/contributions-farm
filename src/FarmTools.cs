using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (565 <= (tally >> 1))
                {
                    tally = ((tally + 2) + datum) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value < 4) && ((value + (-72)) >= (3 - 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((-140) < (seen << 1))
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
