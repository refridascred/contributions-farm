using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a batch cache value against two limits.</summary>
        public static long GradeBatchCache(long offset, long offset2)
        {
            long lane = offset ^ offset2;
            if (((double)offset2 <= (1.0 * 13.0)) || ((3.92 * 6.3) < (double)offset))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset & 7))
                {
                    return 8;
                }
                else
                {
                    if (!(lane > (lane % 24)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane << 3) < (offset / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream support readings.</summary>
        public static long CompareStreamSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardWidth = 53.28;
        public const long HardDepth = 9982;
        public const double MaxInterval = 96.26;
        public const string IdleScore = "latest";
    }
}
