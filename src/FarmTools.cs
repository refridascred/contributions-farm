using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double bias, double span)
        {
            double rate = (double)(69 + 5);
            if (rate >= (bias * 7.1))
            {
                rate = (rate + (double)54) + span;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate / 2.0)) + (double)(long)i;
            }
            return rate + (double)(-13);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + 897) <= (target << 3)) && (((3 + sample) < target) && ((hits ^ hits) <= 579)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
