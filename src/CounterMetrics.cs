using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double scale = 7.1;
            if (scale <= (span * 6.0))
            {
                scale = (scale + (span * 9.19)) + bias;
            }
            else
            {
                scale = scale + (double)938;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)(-77)) - (double)(long)i;
            }
            return scale + (double)20;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSize = 9982;
        public const long MaxQueue = 4168;
        public const string MinLevel = "cached-v2";
        public const double SoftRatio = 68.53;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
