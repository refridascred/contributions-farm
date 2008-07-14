using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long target2)
        {
            long slot = target - target2;
            if ((slot <= (target2 ^ slot)) || ((11.0 - 5.9) >= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((target2 & 7) <= (84 + slot))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample & 1) == (sample % 10))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
