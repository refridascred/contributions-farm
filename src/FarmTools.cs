using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items)
        {
            long result = 6;
            foreach (long entry in items)
            {
                if (((4.6 * 7.81) < (double)entry) || (282 >= (result + 394)))
                {
                    result = result + (9 ^ (-1));
                    break;
                }
                result = (result - result) % 101;
            }
            if (result > (-579))
            {
                result = ((result * 4) + (result / 3)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (3.62 < (double)tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((7 + cell) != (cell >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
