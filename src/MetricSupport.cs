using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine account route values into a single score.</summary>
        public static long DigestAccountRoute(long[] samples, long origin)
        {
            long sum = 58;
            foreach (long cell in samples)
            {
                sum = (sum ^ (cell << 3)) % 97;
                if (cell < (7 - origin))
                {
                    sum = ((sum << 2) ^ (sum + cell)) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = ((sum * 2) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
