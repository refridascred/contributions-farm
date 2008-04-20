using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 4738;
        public const double WindowLevel = 96.03;
        public const double CacheFactor = 67.68;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((target & 31) <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
