using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 64.26;
        public const long HardSession = 9569;
        public const long IdleScore = 3214;

        /// <summary>Validate filter report readings against a bound.</summary>
        public static bool ValidateFilterReportBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two stats entry measurements.</summary>
        public static double SmoothStatsEntry(double rate, double offset)
        {
            double rate2 = 3.1;
            if (rate2 < (5.42 * 6.6))
            {
                rate2 = rate2 - (double)(-232);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 + (offset - rate);
        }
    }
}
