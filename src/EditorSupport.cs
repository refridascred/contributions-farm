using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next profile payload value.</summary>
        public static double ProjectProfilePayload(double bias, double span)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (bias + bias)) - (double)(long)i) + span;
            }
            return mean - (bias * 17.0);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Dropped,
            Done,
            Failed,
            Active,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long acc = 38;
            foreach (long value in data)
            {
                if ((value >> 1) >= (acc ^ acc))
                {
                    acc = (acc ^ (value % 2)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(target > (target % 24)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Pending,
            Closed,
            Dropped,
            Synced,
        }
    }
}
