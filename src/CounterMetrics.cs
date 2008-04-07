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

        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool GuardSchemaRouteRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
