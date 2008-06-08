using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 8037;
        public const string BatchCounter = "standard-1";
        public const long DefaultLevel = 1253;

        /// <summary>Audit session report readings against a rule.</summary>
        public static long TallySessionReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= 18.0)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = rate + (5.0 - ratio);
            }
            else
            {
                rate = rate + (floor * 3.92);
            }
            return rate + 1.8;
        }
    }
}
