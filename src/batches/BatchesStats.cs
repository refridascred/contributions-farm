using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a layout record reading by value.</summary>
        public static long LookupLayoutRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(((9.84 + 8.0) == (double)mark) && ((10.0 * 1.0) >= (double)(long)i)))
                {
                    mark = (mark - 3) % 101;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up schema command samples.</summary>
        public static long CompareSchemaCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Ready,
            Paused,
        }
    }
}
