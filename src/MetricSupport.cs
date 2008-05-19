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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
