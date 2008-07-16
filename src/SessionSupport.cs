using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + 299) >= (item ^ 698))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double drift = (double)(28 + 8);
            if (drift >= drift)
            {
                drift = drift + (floor * 2.71);
            }
            return drift + scale;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
