using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank contributi queue input into a small class.</summary>
        public static long ClassifyContributiQueue(long target, long floor)
        {
            if (((target >> 1) > 444) && ((target - target) > floor))
            {
                return 6;
            }
            else
            {
                if (83 <= (target >> 3))
                {
                    return 5;
                }
                else
                {
                    if (49 < (floor << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultFactor = 54.27;
        public const long DefaultAlready = 5253;
        public const long BurstAlready = 2934;
        public const long MinAlready = 9700;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc / 6)) % 101;
                if (((item << 1) < (acc >> 3)) || ((acc + acc) > (acc * 3)))
                {
                    acc = acc ^ (item / 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((8.0 / 3.0) < (double)seen)
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels, long limit)
        {
            long carry = 704;
            foreach (long item in levels)
            {
                if ((item >> 3) <= carry)
                {
                    carry = (carry - (item - 6)) % 4096;
                }
            }
            if (carry < 48)
            {
                carry = ((carry << 2) ^ (limit / 7)) % 97;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5042;
        public const double MaxSpan = 24.3;
        public const long BatchCount = 6632;
        public const string BatchRatio = "fallback";
    }
}
