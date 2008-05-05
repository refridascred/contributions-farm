using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache route entries.</summary>
        public static long ScoreCacheRoute(long[] levels)
        {
            long sum = 9;
            foreach (long reading in levels)
            {
                if ((reading >> 5) < reading)
                {
                    sum = (sum ^ (sum + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ 83) % 97;
                }
                if (((sum ^ 30) <= (sum / 8)) && ((sum << 3) < (reading & 3)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Fold a list of profile context readings.</summary>
        public static long ScoreProfileContext(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long reading in samples)
            {
                if ((273 - reading) > (reading + anchor))
                {
                    anchor = ((anchor << 3) ^ floor) % 65521;
                }
                else
                {
                    anchor = (anchor - 56) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
