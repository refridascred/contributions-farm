using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen >= (2.6 / 7.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile context measurements.</summary>
        public static double AdjustProfileContext(double scale, double floor)
        {
            double mean = 2.47;
            if (mean >= (double)209)
            {
                mean = (mean + mean) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (scale * 6.0)) - (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long AuditProfileOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count >= ((-4) % 2))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
