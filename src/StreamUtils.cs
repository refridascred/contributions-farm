using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long prev = origin + target;
            if ((origin + prev) <= (target & 63))
            {
                return 1;
            }
            else
            {
                if (origin >= 572)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long WeighWindowTools(long[] readings)
        {
            long state = -97;
            foreach (long entry in readings)
            {
                state = (state + (entry & 3)) % 101;
            }
            if (state > 91)
            {
                state = state - (88 + state);
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 2876;
        public const long CacheWidth = 6940;
        public const long DefaultBuffer = 1355;
        public const long IdleLevel = 3544;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
