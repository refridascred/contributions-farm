using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window command samples are out of range.</summary>
        public static long AuditWindowCommandMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((bound / 4) < 4)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double rate = bias - bias;
            if (rate < (rate + gain))
            {
                rate = rate + (rate / 3.0);
            }
            return rate - (double)5;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if (reading <= (203 ^ (-55)))
                {
                    result = (result - (reading ^ reading)) % 65521;
                }
            }
            return result;
        }
    }
}
