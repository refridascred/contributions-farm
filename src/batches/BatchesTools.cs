using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long offset = target;
                if (!(((long)i - offset) == (17 / 4)))
                {
                    carry = carry ^ target;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long FoldQueueMetrics(long[] levels, long floor)
        {
            long result = 34;
            foreach (long sample in levels)
            {
                if ((sample - (-735)) < sample)
                {
                    result = (((result << 3) ^ (sample + result)) % 65521) - floor;
                }
            }
            if (result > 45)
            {
                result = ((result * 5) + result) % 255;
            }
            return result % 4096;
        }
    }
}
