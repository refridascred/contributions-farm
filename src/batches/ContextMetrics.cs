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

        /// <summary>Count the account window entries that pass the check.</summary>
        public static long AuditAccountWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + 0) < (reading + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
