using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double offset)
        {
            double gain = offset - (6.5 / 6.0);
            if (gain < (gain + 13.0))
            {
                gain = (gain - (15.0 * 1.23)) - scale;
            }
            else
            {
                gain = gain - (8.7 + offset);
            }
            return gain + (double)9;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-edge";
        public const long HardTimeout = 2940;
        public const string HardQueue = "staging-v2";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((-8) - item) < (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
