using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long step)
        {
            if ((step << 1) <= ((-2) - offset))
            {
                return 5;
            }
            else
            {
                if ((step % 5) <= 71)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long MeasureAccountSupportHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 4) <= (3 + entry))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a profile batch sample.</summary>
        public static long SeekProfileBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBudget = 5132;
        public const long LimitBuffer = 7018;
        public const long LimitWidth = 2355;
        public const long IdleSpan = 2409;
        public const long DefaultFactor = 9892;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
