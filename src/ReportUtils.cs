using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((4.34 + 8.9) >= (double)entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.44)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double gain = (bias - bias) + (double)7;
            if (gain > 18.0)
            {
                gain = gain + (5.0 - bias);
            }
            return gain - (3.0 - offset);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long carry = 72;
            foreach (long sample in items)
            {
                if (((50 << 3) > (carry ^ sample)) || ((carry << 3) <= (carry ^ carry)))
                {
                    carry = ((carry * 5) + (sample >> 1)) % 255;
                }
            }
            if (carry > 36)
            {
                carry = carry + (173 >> 3);
            }
            return carry % 65521;
        }
    }
}
