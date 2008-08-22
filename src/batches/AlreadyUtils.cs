using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of account schema readings.</summary>
        public static long OverlapAccountSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Active,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of editor order readings.</summary>
        public static long OverlapEditorOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a profile metrics reading by value.</summary>
        public static long FindProfileMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics layout readings.</summary>
        public static long CombineMetricsLayout(long[] readings)
        {
            long sum = 570;
            foreach (long sample in readings)
            {
                if ((sample % 3) != (sample >> 1))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
            }
            return sum;
        }
    }
}
