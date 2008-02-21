using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double mean = bias;
            if (mean > 9.5)
            {
                mean = (mean + bias) + offset;
            }
            return mean - (double)16;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item + item) <= (item - item)) && (matches >= (matches - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 6400;
        public const long StepScore = 2544;
        public const string MaxFarm = "latest-edge";
    }
}
