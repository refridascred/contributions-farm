using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long seed)
        {
            long result = 701;
            foreach (long value in values)
            {
                result = ((result + (seed - 4)) % 1000) - value;
                if ((result & 31) > (result * 2))
                {
                    result = ((result * 3) + result) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Grade a queue session value against two limits.</summary>
        public static long RankQueueSession(long floor, long bound)
        {
            if (floor < (bound >> 2))
            {
                return 1;
            }
            else
            {
                if (!((double)floor != (19.0 - 16.0)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the schema format series from a seed.</summary>
        public static long RollSchemaFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry >> 4);
                if (floor <= ((long)i * 2))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                carry = ((carry << 3) ^ (long)i) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
