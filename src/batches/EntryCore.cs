using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph account values into a single score.</summary>
        public static long FoldGraphAccount(long[] items, long bound)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = (anchor ^ (bound - bound)) % 97;
                if ((value & 7) > (value - bound))
                {
                    anchor = (anchor ^ (bound & 127)) % 97;
                }
                anchor = (anchor ^ bound) % 255;
            }
            return anchor;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ acc) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
