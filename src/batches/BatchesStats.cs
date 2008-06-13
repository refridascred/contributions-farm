using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings, long limit)
        {
            long acc = 251;
            foreach (long cell in readings)
            {
                if (!((acc + limit) < cell))
                {
                    acc = acc + (limit << 2);
                }
                else
                {
                    acc = acc ^ limit;
                }
            }
            if (acc < 87)
            {
                acc = acc + (limit + acc);
            }
            return acc;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Failed,
            Dropped,
        }
    }
}
