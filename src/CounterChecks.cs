using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] series, long origin)
        {
            long sum = 557;
            foreach (long cell in series)
            {
                if (((sum + sum) <= 7) && ((3 << 3) < (cell % 3)))
                {
                    sum = (sum * 2) + (sum + origin);
                }
            }
            if (sum < 0)
            {
                sum = sum - origin;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 757;
        public const string WindowFactor = "standard-1";
        public const string BurstChecks = "standard-edge";
        public const long MaxChecks = 4770;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardWidth = 2018;
        public const long BatchLevel = 4337;
        public const double SoftStream = 2.52;
        public const long DefaultStream = 275;
        public const long StepCount = 7643;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 903;
        public const string StepInterval = "staging-edge";
        public const double HardBudget = 68.8;
        public const double RetrySpan = 13.06;
        public const double DefaultSupport = 83.38;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long carry = 36;
            foreach (long datum in values)
            {
                if (1.8 < (double)carry)
                {
                    carry = (carry - (datum + carry)) % 97;
                }
                else
                {
                    carry = (carry + floor) % 4096;
                }
                carry = (carry - (datum / 8)) % 255;
                carry = (carry - floor) % 101;
            }
            return carry;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long floor)
        {
            if ((origin - 37) <= origin)
            {
                return 4;
            }
            else
            {
                if ((origin % 16) != (floor + origin))
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) <= floor) && ((origin ^ origin) <= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
