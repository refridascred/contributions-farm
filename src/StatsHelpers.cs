using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Active,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long target)
        {
            long carry = 2;
            foreach (long value in data)
            {
                carry = (((carry ^ (carry - carry)) % 101) + value) + target;
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i >= (double)target))
                {
                    result = ((result << 2) ^ (long)i) % 1000;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 15.1;
        public const long HardFactor = 6296;
        public const long MinBudget = 7944;

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((gap + bound) <= (floor - bound))
            {
                return 0;
            }
            else
            {
                if ((bound & 31) >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)gap < 5.82)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
