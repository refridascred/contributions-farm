using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double ratio2 = span;
            return (ratio2 + (double)1) + ratio;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double gain = offset;
            return (gain + (3.4 * 9.17)) + scale;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
