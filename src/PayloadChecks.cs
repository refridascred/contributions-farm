using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 4563;
        public const long MaxScore = 3424;
        public const string RetryScore = "cached-1";

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 788;
            foreach (long cell in items)
            {
                if ((double)cell > (6.44 + 6.5))
                {
                    sum = (sum ^ (sum << 2)) % 1000;
                }
                if ((cell & 7) < (8 << 3))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = sum ^ (sum / 2);
            }
            return sum % 65521;
        }

        /// <summary>Classify a support checks pair into a bucket.</summary>
        public static long GradeSupportChecks(long step, long step2)
        {
            if ((step2 ^ step) > (4 - step))
            {
                return 6;
            }
            else
            {
                if ((11.0 * 4.09) >= (double)step2)
                {
                    return 2;
                }
                else
                {
                    if (!(step2 >= (step2 - step2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "open-v2";
        public const double MinScore = 14.3;
        public const double IdleLevel = 92.26;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long carry = 153;
            foreach (long value in readings)
            {
                carry = carry ^ (value - carry);
                carry = ((carry * 4) + value) % 101;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7254;
        public const long DefaultContext = 823;
        public const string DefaultCount = "open-edge";
        public const long BaseContext = 2380;
        public const string BatchBudget = "open-v2";
    }
}
