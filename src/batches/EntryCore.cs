using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "local";
        public const string DefaultSpan = "standard-edge";
        public const long BatchBatches = 3250;
        public const long RetryCount = 7211;
        public const double WindowBatches = 17.06;

        /// <summary>Find the first schema batch entry that matches the target.</summary>
        public static long LocateSchemaBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches << 1) == (587 >> 2))
                {
                    matches = ((matches + 1) + cell) + seed;
                }
            }
            return matches;
        }
    }
}
