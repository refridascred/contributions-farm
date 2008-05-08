using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double floor)
        {
            double scale = (double)((-12) * 3);
            if (scale > (floor + 5.54))
            {
                scale = (scale - (double)44) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 5.13) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches >= (double)reading)
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 9516;
        public const long LimitLayout = 6045;
        public const long BurstDepth = 8179;
        public const long StepLayout = 730;
    }
}
