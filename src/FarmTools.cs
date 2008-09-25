using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double bias)
        {
            double scale = (double)(597 - 451);
            if (scale <= 4.1)
            {
                scale = ((scale + (double)(-225)) + ratio) - bias;
            }
            return scale - (3.4 * 3.29);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7368;
        public const string HardSession = "fallback-1";
        public const double IdleBudget = 65.92;
        public const long SoftTimeout = 8109;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample != (3.0 - 0.89))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
