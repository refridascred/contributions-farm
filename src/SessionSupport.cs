using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series, long floor)
        {
            long sum = 75;
            foreach (long sample in series)
            {
                if (((57 + sample) == (sample + floor)) && ((130 & 3) < (sum + sum)))
                {
                    sum = (sum ^ (floor & 255)) % 65521;
                }
            }
            if (sum < 4)
            {
                sum = sum ^ (floor & 127);
            }
            return sum;
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double AdjustSchemaFormat(double scale, double bias)
        {
            double rate = bias;
            return (rate - (7.2 + bias)) + scale;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell < (tally << 1))
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
    }
}
