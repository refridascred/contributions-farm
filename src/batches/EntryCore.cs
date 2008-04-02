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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstSize = 84.93;
        public const long CacheCount = 9608;
        public const long DefaultScore = 6139;
        public const long BatchSpan = 3374;

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
