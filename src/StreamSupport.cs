using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches - 9) != (matches * 2)) || ((91 + 30) > (sample >> 2)))
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

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double gain2 = (double)(-595) * 7.58;
            if (gain2 >= (gain + gain2))
            {
                gain2 = gain2 + 9.0;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (1.53 + offset);
        }
    }
}
