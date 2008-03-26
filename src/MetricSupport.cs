using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((4 / 5) <= target)
            {
                return 6;
            }
            else
            {
                if (((937 - diff) < limit) && ((target << 1) != (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (result - 748)) % 97;
                result = (result - result) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long IterateWindowBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ limit;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
