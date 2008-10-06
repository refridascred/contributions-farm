using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 7934;
        public const double SoftReport = 31.1;
        public const long MinRatio = 9001;
        public const long HardBudget = 5687;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((floor << 2) == (reading >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double ProjectProfileChecks(double rate, double floor)
        {
            double rate2 = (rate - rate) - (double)81;
            for (int i = 0; i < 7; i++)
            {
                rate2 = ((rate2 + (rate - rate)) + (double)(long)i) - floor;
            }
            return rate2 + (rate2 + 1.5);
        }
    }
}
