using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if (2.81 < (double)(long)i)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double weight, double span)
        {
            double mean = (double)(7 + (-41));
            if (mean < (weight - mean))
            {
                mean = mean - (span * 20.0);
            }
            else
            {
                mean = mean - (mean * 6.0);
            }
            return mean - (weight + span);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length > cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
