using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine schema context values into a single score.</summary>
        public static long CombineSchemaContext(long[] samples)
        {
            long mark = 455;
            foreach (long value in samples)
            {
                if (!((mark + mark) > mark))
                {
                    mark = (mark + value) % 1000;
                }
            }
            if (mark < (-78))
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((slot + origin) < (slot + slot))
            {
                return 6;
            }
            else
            {
                if ((origin & 3) != (slot - seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
