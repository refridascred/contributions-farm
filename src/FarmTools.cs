using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long MeasureProfileLayoutMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((floor >> 3) <= value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes layout value.</summary>
        public static double SmoothNotesLayout(double weight, double floor)
        {
            double load = (weight - 3.91) - (weight * 3.0);
            if (load >= (double)(-727))
            {
                load = load + (5.67 + weight);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor / 4.0)) + (double)(long)i;
            }
            return load + (double)93;
        }
    }
}
