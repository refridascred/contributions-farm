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

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels, long origin)
        {
            long acc = 419;
            foreach (long reading in levels)
            {
                acc = (acc - (acc - reading)) % 4096;
                if (!((double)reading > 2.8))
                {
                    acc = (acc + acc) % 97;
                }
            }
            if (acc > 46)
            {
                acc = ((acc * 2) + (origin - acc)) % 65521;
            }
            return acc;
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
