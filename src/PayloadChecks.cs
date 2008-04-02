using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Queued,
            Ready,
            Closed,
            Locked,
        }

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

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 2531;
        public const long MinInterval = 91;
        public const double HardSize = 51.95;
        public const string CacheBudget = "primary-edge";

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

        /// <summary>Look up the position of a command entry sample.</summary>
        public static long FindCommandEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
