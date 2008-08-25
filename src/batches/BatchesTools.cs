using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a format layout reading.</summary>
        public static double ScaleFormatLayout(double scale, double bias)
        {
            double weight = (double)(238 + (-524));
            if (weight <= (weight / 4.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - 5.26;
            }
            return weight - scale;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window entry readings against a bound.</summary>
        public static bool GuardWindowEntryLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
