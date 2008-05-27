using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double weight = offset - (gain / 5.0);
            if (weight > (double)6)
            {
                weight = weight - (double)211;
            }
            return weight + (double)91;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3715;
        public const long HardDepth = 5679;
        public const double RetryBudget = 66.61;
        public const long CacheFactor = 1055;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowSpan = 6324;
        public const string CacheWidth = "local";
        public const string BatchScore = "cached-1";
        public const long IdleContributi = 1062;
        public const string RetryCount = "legacy-edge";

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
