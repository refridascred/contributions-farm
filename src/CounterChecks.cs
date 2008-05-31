using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item <= (2 % 8))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long sum = 159;
            foreach (long value in data)
            {
                sum = (sum + 458) - value;
                if (sum <= (970 / 5))
                {
                    sum = (sum ^ (sum & 31)) % 101;
                }
            }
            if (sum < 1)
            {
                sum = (sum - (sum >> 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - (seed - sum)) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double rate, double span)
        {
            double mean = (rate - span) - rate;
            if (mean > span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (mean - span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 10.0) + (double)(long)i;
            }
            return mean - (rate / 8.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long carry = 41;
            foreach (long item in levels)
            {
                if ((carry > (item + carry)) || (item > (carry - carry)))
                {
                    carry = carry - (item + carry);
                }
            }
            return carry % 65521;
        }
    }
}
