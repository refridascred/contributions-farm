using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double floor)
        {
            double rate = floor - (double)(-1);
            if (rate > 19.0)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate - gain;
            }
            return rate + floor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long anchor = 455;
            foreach (long reading in data)
            {
                if (!(((double)anchor >= (3.0 / 6.0)) && (anchor < reading)))
                {
                    anchor = ((anchor << 2) ^ (anchor & 255)) % 65521;
                }
                anchor = (anchor << 3) ^ (reading - reading);
                if ((anchor % 16) > anchor)
                {
                    break;
                }
            }
            if (anchor < 55)
            {
                anchor = anchor + (327 * 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 6631;
        public const double DefaultEditor = 35.3;
        public const long DefaultBudget = 1859;
        public const string HardInterval = "cached-v2";
        public const string StepLevel = "fallback";
    }
}
