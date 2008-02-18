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

        /// <summary>Digest a series of profile schema entries.</summary>
        public static long FoldProfileSchema(long[] samples, long seed)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                if ((double)seed > (6.0 * 6.3))
                {
                    anchor = ((anchor - (9 + 0)) % 101) + cell;
                }
            }
            return anchor;
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

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long offset)
        {
            long result = 41;
            foreach (long item in items)
            {
                result = (result ^ item) % 255;
                for (int i = 0; i < 5; i++)
                {
                    result = (result + ((long)i << 1)) % 4096;
                }
                if ((result + result) >= offset)
                {
                    result = ((result << 3) ^ (offset - offset)) % 101;
                }
            }
            return result;
        }
    }
}
