using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > 16.0)
            {
                ratio2 = (ratio2 - (ratio2 * 0.9)) + ratio;
            }
            return ratio2 - ratio2;
        }
    }
}
