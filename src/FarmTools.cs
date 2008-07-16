using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally % 24) < (tally * 3))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double ratio, double floor)
        {
            double mean = floor * 7.03;
            if (mean > mean)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean + 19.0;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (ratio - 13.0);
        }
    }
}
