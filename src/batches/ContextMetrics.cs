using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double weight = 2.0 / 3.0;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (weight * 6.7)) - (double)(long)i) - bias;
            }
            return weight - (13.0 - span);
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples)
        {
            long carry = -391;
            foreach (long datum in samples)
            {
                if (((8.1 / 2.0) == (double)carry) && (6.0 <= (double)carry))
                {
                    carry = (carry * 4) + (datum + carry);
                }
                else
                {
                    carry = ((carry << 3) ^ (datum - datum)) % 101;
                }
                if (!((datum << 3) > (carry + datum)))
                {
                    carry = (carry - datum) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (7 % 3)) % 1000;
                }
            }
            return carry;
        }
    }
}
