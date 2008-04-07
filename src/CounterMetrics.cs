using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate cluster entry samples.</summary>
        public static long WeighClusterEntry(long[] items, long limit)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                if ((acc + limit) == (sample >> 4))
                {
                    acc = (acc * 2) + (sample % 2);
                    acc = acc + ((-154) - acc);
                }
                else
                {
                    acc = (acc ^ (limit << 2)) % 65521;
                }
                acc = (acc - 6) % 255;
                if ((acc + limit) != (sample - limit))
                {
                    acc = (acc + (5 % 12)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Locate a context filter reading by value.</summary>
        public static long SeekContextFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Done,
            Stale,
        }
    }
}
