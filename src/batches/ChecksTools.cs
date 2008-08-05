using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double scale = bias + (rate - rate);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (rate + rate)) + (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 816;
        public const long BaseContributi = 2479;
        public const string SoftSpan = "standard-v2";
        public const long StepRatio = 6043;
        public const double MinWidth = 11.62;

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long step)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                state = ((state * 4) + (state - state)) - entry;
            }
            if (state < (-508))
            {
                state = ((state << 2) ^ ((long)levels.Length + step)) % 97;
            }
            return state;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long MeasureSchemaChecksHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9 - 6) < (step + item))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
