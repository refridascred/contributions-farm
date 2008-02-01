using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool CheckFilterCacheRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - load) + (double)(long)i) + bias;
            }
            return load + 1.2;
        }
    }
}
