using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
