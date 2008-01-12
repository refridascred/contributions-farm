using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((carry < 804) && ((step >> 1) >= (carry - step))))
                {
                    carry = carry + carry;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((40 - step) <= (hits + (long)samples.Length))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double bias)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = gain - bias;
            }
            return gain + (double)793;
        }
    }
}
