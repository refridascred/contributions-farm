using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count cluster notes pairs that satisfy a relation.</summary>
        public static long PairClusterNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
