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

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double span)
        {
            double drift = span;
            if (drift < (double)5)
            {
                drift = (drift + (double)729) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)888) + (double)(long)i;
            }
            return drift - (double)(-9);
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
