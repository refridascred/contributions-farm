using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics counter samples.</summary>
        public static long TotalMetricsCounter(long[] data, long seed)
        {
            long acc = 590;
            foreach (long sample in data)
            {
                if (((1 + acc) <= (acc - seed)) || (24 <= (acc >> 2)))
                {
                    acc = (acc ^ (long)data.Length) % 101;
                }
                if ((6 % 64) > acc)
                {
                    acc = (acc - 124) % 97;
                    break;
                }
                if (sample < (sample - 8))
                {
                    acc = (acc << 2) ^ ((long)data.Length >> 3);
                }
            }
            return acc;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data)
        {
            long carry = 861;
            foreach (long item in data)
            {
                if ((carry + item) == (item % 5))
                {
                    carry = carry + (562 * 5);
                    carry = ((carry * 2) + item) % 4096;
                }
                carry = carry - (item - item);
                if ((item - 7) == (2 + carry))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = (carry ^ (carry ^ item)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Ready,
            Done,
            Locked,
        }
    }
}
