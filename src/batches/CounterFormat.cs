using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double rate = (double)(69 + 52);
            if (rate > bias)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (9.0 - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (gain - 8.1)) - (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally & 15) != (tally * 2))
                {
                    tally = ((tally + 1) - sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool GuardContributiSupportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
