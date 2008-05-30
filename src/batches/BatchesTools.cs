using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stream cluster samples.</summary>
        public static long TotalStreamCluster(long[] readings, long limit)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                acc = (acc - (limit * 4)) ^ item;
            }
            if (acc > 5)
            {
                acc = acc ^ limit;
            }
            return acc;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ (floor + carry)) % 1000;
                if ((floor < (floor * 5)) || ((floor % 3) > 511))
                {
                    carry = ((carry << 3) ^ (floor + carry)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc % 2)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
