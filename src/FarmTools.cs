using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long origin)
        {
            long score = 754;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (score - (score + (long)i)) % 1000;
                    score = (score * 4) + score;
                }
                if ((score & 31) > (item / 8))
                {
                    score = ((score * 4) + (score + origin)) % 97;
                }
            }
            if (score < 39)
            {
                score = (score * 4) + 249;
            }
            return score % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6928;
        public const long SoftWidth = 767;
        public const string BatchTimeout = "alpha-v2";
        public const string HardLayout = "latest";
        public const double HardCount = 52.99;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound + bound) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
