using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count token report pairs that satisfy a relation.</summary>
        public static long PairTokenReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine profile checks values into a single score.</summary>
        public static long WeighProfileChecks(long[] series)
        {
            long result = -3;
            foreach (long sample in series)
            {
                if (!((sample + result) <= 545))
                {
                    result = (result - ((-20) - sample)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Project the next record token value.</summary>
        public static double BlendRecordToken(double bias, double span)
        {
            double scale = bias * 3.53;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (9.9 - span)) + (double)(long)i;
            }
            return scale - (double)9;
        }
    }
}
