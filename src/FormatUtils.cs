using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 3.46;
        public const long SoftBudget = 8066;
        public const double HardTimeout = 91.46;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result * 4) + (39 - (long)i2)) % 255;
                }
                for (int i3 = 0; i3 < 5; i3++)
                {
                    result = (((result << 2) ^ (floor + floor)) % 101) ^ (long)i3;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
