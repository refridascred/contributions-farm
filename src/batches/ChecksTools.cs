using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "cached-1";
        public const long SoftDepth = 7722;
        public const long CacheAccount = 879;
        public const long BatchInterval = 4262;

        /// <summary>Fold a list of token already readings.</summary>
        public static long ScoreTokenAlready(long[] samples, long limit)
        {
            long result = 23;
            foreach (long datum in samples)
            {
                if (datum < result)
                {
                    result = ((result << 3) ^ (result & 127)) % 97;
                }
                result = (result * 5) + (limit / 6);
                result = ((result * 5) + (datum / 7)) % 1000;
            }
            return result;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double gain, double offset)
        {
            double load = offset;
            if (load <= offset)
            {
                load = (load + load) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)465) + (double)(long)i;
            }
            return load - (load + 8.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 5400;
        public const string WindowLevel = "cached";
        public const long BurstInterval = 9727;
        public const double IdleCount = 76.89;
        public const double MinEditor = 19.54;
    }
}
