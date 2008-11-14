using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double floor)
        {
            double scale = (6.81 + floor) - (floor / 9.0);
            return (scale - floor) + gain;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 7375;
        public const long SoftScore = 2445;
        public const long BaseChannel = 6588;

        /// <summary>Look up the position of a entry order sample.</summary>
        public static long FindEntryOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter window readings.</summary>
        public static long PairFilterWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
